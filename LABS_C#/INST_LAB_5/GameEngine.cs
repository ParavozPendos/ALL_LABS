using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace LIFE_GAME
{
    public class GameEngine
    {
        public uint CurrentGeneration { get; private set; }
        private bool[,] field;
        private readonly int rows;
        private readonly int cols;

        private uint rule_CellBorn;
        private uint rule_CellDieLess;
        private uint rule_CellDieMore;
        

        public GameEngine(int rows, int cols, int dencity, uint rule_CellBorn, uint rule_CellDieLess, uint rule_CellDieMore)
        {
            this.rows = rows;
            this.cols = cols;

            this.rule_CellBorn = rule_CellBorn;
            this.rule_CellDieLess = rule_CellDieLess;
            this.rule_CellDieMore = rule_CellDieMore;

            field = new bool[cols, rows];

            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next(dencity) == 0;
                }
            }
        }

        private int CountNeighbours(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int col = (x + i + cols) % cols;
                    int row = (y + j + rows) % rows;

                    bool isSelfChecking = col == x && row == y;
                    bool hasLife = field[col, row];
                    if (hasLife && !isSelfChecking)
                        count++;
                }
            }
            return count;
        }
        public void NextGeneration()
        {         
            var newField = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeighbours(x, y);
                    var hasLife = field[x, y];

                    if (!hasLife && (neighboursCount == rule_CellBorn))
                        newField[x, y] = true;
                    else if (hasLife && (neighboursCount < rule_CellDieLess || neighboursCount > rule_CellDieMore))
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];
                }
            }
            field = newField;
            CurrentGeneration++;
        }
        public void FieldClear()
        {
            for(int x = 0;x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = false;
                }
            }
        }

        public bool[,] GetCurrentGeneration()
        {
            var result = new bool[cols, rows];
            for(int x = 0; x < cols; x++)
            {
                for(int y = 0;y < rows; y++)
                {
                    result[x, y] = field[x, y];
                }
            }
            return field;

        }
        private bool ValidateCellPos(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }
        private void UpdatedCell(int x, int y, bool state)
        {
            if (ValidateCellPos(x, y))
                field[x, y] = state;
        }

        public void AddCell(int x, int y)
        {
            UpdatedCell(x, y, true);
        }
        public void RemoveCell(int x, int y)
        {
            UpdatedCell(x, y, false);
        }

    }
}
