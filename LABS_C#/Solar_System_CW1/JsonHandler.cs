using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Solar_System_CW1
{
    public class SavedBody
    {
        public string name { get; set; }
        public string description { get; set; }
        public Coordinate currentPos { get; set; }
        public string parentName { get; set; }
        public double radius { get; set; }
        public double speed { get; set; }
        public double size { get; set; }
        public int colorArgb { get; set; }
        public double angle { get; set; }
    }

    public static class JsonHandler
    {
        public static void SaveToFile(string filePath)
        {
            try
            {
                List<SavedBody> data = Tbody.AllObjects.Select(body => new SavedBody
                {
                    name = body.name,
                    description = body.description,
                    currentPos = body.currentPos,
                    parentName = body.parent?.name,
                    radius = body.radius,
                    speed = body.speed,
                    size = body.size,
                    colorArgb = (body.color as SolidBrush)?.Color.ToArgb() ?? Color.Black.ToArgb(),
                    angle = body.angle
                }).ToList();

                File.WriteAllText(filePath, JsonConvert.SerializeObject(data, Formatting.Indented));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }

        public static void LoadFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Tbody.InitializeSolarSystem();
                    return;
                }

                string json = File.ReadAllText(filePath);
                var savedBodies = JsonConvert.DeserializeObject<List<SavedBody>>(json);

                if (savedBodies == null || savedBodies.Count == 0)
                {
                    Tbody.InitializeSolarSystem();
                    return;
                }

                var roots = Tbody.AllObjects.Where(obj => obj.parent == null).ToList();
                foreach (var root in roots) Tbody.Deleter(root);

                var objectsDict = new Dictionary<string, Tbody>();

                foreach (var savedBody in savedBodies)
                {
                    var body = new Tbody
                    (
                        name: savedBody.name,
                        description: savedBody.description,
                        currentPos: savedBody.currentPos,
                        parent: null, 
                        radius: savedBody.radius,
                        speed: savedBody.speed,
                        size: savedBody.size,
                        color: new SolidBrush(Color.FromArgb(savedBody.colorArgb)),
                        angle: savedBody.angle
                    );

                    objectsDict[body.name] = body;
                }

                foreach (var savedBody in savedBodies)
                {
                    Tbody parent = null;
                    if (!string.IsNullOrEmpty(savedBody.parentName))
                    {
                        objectsDict.TryGetValue(savedBody.parentName, out parent);
                    }

                    var body = objectsDict[savedBody.name];
                    body.parent = parent;

                    if (parent != null)
                    {
                        parent.AddSatellite(body);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}\nЗагружаю стандартную систему");
                Tbody.InitializeSolarSystem();
            }
        }
    }
}