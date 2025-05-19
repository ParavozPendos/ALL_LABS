using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solar_System_CW1
{
    internal class Tbody
    {
        public static List<Tbody> AllObjects = new List<Tbody>();

        public Tbody(
            string name,
            string description,
            Coordinate currentPos,
            Tbody parent,
            double radius,
            double speed,
            double size,
            Brush color,

            double angle = 0
        )
        {
            this.name = name;
            this.description = description;
            this.currentPos = currentPos;
            this.parent = parent;
            this.radius = radius;
            this.speed = speed;
            this.size = size;
            this.color = color;
            this.angle = angle;
            this.rotationCenter = parent != null ? parent.currentPos : new Coordinate();

            AllObjects.Add(this);
        }

        public string name { get; set; }
        public string description { get; set; }
        public Coordinate currentPos { get; set; }
        public Coordinate rotationCenter { get; set; }
        public Tbody parent { get; set; }
        public double radius { get; set; }
        public double speed { get; set; }
        public double size { get; set; }
        public Brush color { get; set; }
        public double angle { get; set; }
        public List<Tbody> satelliteList = new List<Tbody>();


        public void AddSatellite(params Tbody[] satellites)
        {
            satelliteList.AddRange(satellites);
        }
        public bool IsPointOnBody(Coordinate point, double currentScale)
        {
            // Проверяем попадание в круг
            double dx = point.x - currentPos.x;
            double dy = point.y - currentPos.y;
            return dx * dx + dy * dy <= size * size;
        }



        public static void Deleter(Tbody body)
        {
            if (body.satelliteList.Count != 0)
            {
                foreach (var item in body.satelliteList)
                {
                    Deleter(item);
                }
            }
            AllObjects.Remove(body);
        }
        public static void InitializeSolarSystem()
        {
            //Солнце
            Tbody Sun = new Tbody(
                description:
                "Центральная звезда нашей планетарной системы, вокруг которой вращаются все остальные объекты. \n" +
                "Представляет собой огромный раскалённый плазменный шар, излучающий свет и энергию. \n" +
                "Играет ключевую роль в поддержании жизни на Земле, определяя климат и погодные условия. \n" +
                "В древних культурах почиталось как божество. Современная наука изучает солнечную активность и её влияние на космическую погоду.",

                name: "Sun",
                currentPos: new Coordinate(),
                parent: null,
                radius: 0,
                speed: 0,
                size: 10,
                color: Brushes.Yellow
            );

            //Земля
            Tbody Earth = new Tbody(
                description:
                "Уникальная голубая планета, единственная известная науке, где существует жизнь. \n" +
                "Отличается наличием больших запасов жидкой воды и кислородной атмосферы. \n" +
                "Имеет сложную геологическую структуру с подвижными тектоническими плитами. \n" +
                "Естественный спутник - Луна - оказывает значительное влияние на приливы и отливы. \n" +
                "На поверхности сочетаются океаны, материки и разнообразные экосистемы.",

                name: "Earth",
                currentPos: new Coordinate(150, 0),
                parent: Sun,
                radius: 150,
                speed: 0.1,
                size: 6,
                color: Brushes.Green
            );

            //Марс
            Tbody Mars = new Tbody(
                description:
                "Красноватая планета, получившая своё название в честь римского бога войны. \n" +
                "Поверхность покрыта кратерами, вулканами и каньонами, включая гигантскую систему долин Маринер. \n" +
                "Атмосфера разрежена и непригодна для дыхания. В прошлом, вероятно, имела реки и озёра. \n" +
                "Интерес учёных вызывает возможное наличие примитивной жизни в прошлом или настоящем. \n" +
                "Имеет два небольших спутника неправильной формы.",

                name: "Mars",
                currentPos: new Coordinate(228, 0),
                parent: Sun,
                radius: 228,
                speed: 0.053,
                size: 4,
                color: Brushes.Red
            );

            //Венера
            Tbody Venus = new Tbody(
                description:
                "Ярчайший объект на ночном небе после Луны, названный в честь богини любви. \n" +
                "Покрыта плотным слоем облаков, создающих сильный парниковый эффект. \n" +
                "Поверхность скрыта от наблюдения, но радиолокационные исследования выявили многочисленные вулканы и лавовые равнины. \n" +
                "Вращается в обратном направлении по сравнению с другими планетами. \n" +
                "Атмосферное давление у поверхности чрезвычайно высокое.",

                name: "Venus",
                currentPos: new Coordinate(108, 0),
                parent: Sun,
                radius: 108,
                speed: 0.416,
                size: 5,
                color: Brushes.OrangeRed
            );

            //Меркурий
            Tbody Mercury = new Tbody(
                description:
                "Самая маленькая и ближайшая к Солнцу планета системы. \n" +
                "Характеризуется крайне разреженной газовой оболочкой. \n" +
                "Поверхность испещрена многочисленными ударными кратерами, напоминающими лунный ландшафт. \n" +
                "Имеет крупное железное ядро, составляющее значительную часть её объёма. \n" +
                "Из-за близости к светилу наблюдать его с Земли можно только на рассвете или закате. \n" +
                "Совершает сложное движение по орбите.",

                name: "Mercury",
                currentPos: new Coordinate(58, 0),
                parent: Sun,
                radius: 58,
                speed: 0.416,
                size: 3,
                color: Brushes.RosyBrown
            );

            //Луна
            Tbody Moon = new Tbody(
                description:
                "Единственный естественный спутник Земли, оказывающий существенное влияние на нашу планету. \n" +
                "Поверхность состоит из светлых материковых и тёмных морских участков, образованных древними лавовыми потоками. \n" +
                "Отсутствие атмосферы приводит к резким перепадам между дневными и ночными температурами. \n" +
                "Является самым изученным внеземным телом, на которое высаживались люди. \n" +
                "Приливы, вызываемые её гравитацией, важны для земных экосистем.",

                name: "Moon",
                currentPos: new Coordinate(Earth.currentPos.x + 15, 0),
                parent: Earth,
                radius: 15,
                speed: 1.3,
                size: 2,
                color: Brushes.WhiteSmoke
            );

            //Фобос
            Tbody Phobos = new Tbody(
                description:
                "Больший из двух марсианских спутников, названный в честь мифологического персонажа, олицетворявшего страх. \n" +
                "Имеет неправильную форму с многочисленными кратерами и бороздами. \n" +
                "Орбита расположена экстремально близко к поверхности Марса. \n" +
                "Постепенно приближается к планете под действием приливных сил. \n" +
                "Поверхность покрыта толстым слоем реголита. \n" +
                "Предполагается, что может быть захваченным астероидом.",

                name: "Phobos",
                currentPos: new Coordinate(Mars.currentPos.x + 7, 0),
                parent: Mars,
                radius: 7,
                speed: 114.4,
                size: 1,
                color: Brushes.DarkGray
            );

            //Деймос
            Tbody Deimos = new Tbody(
                description:
                "Меньший спутник Марса, получивший имя мифологического бога ужаса. \n" +
                "Отличается более гладкой поверхностью по сравнению с Фобосом, так как большинство кратеров засыпаны рыхлым материалом. \n" +
                "Орбита постепенно удаляется от Марса. Имеет вытянутую форму с относительно ровными очертаниями. \n" +
                "Как и Фобос, вероятно, является захваченным астероидом. \n" +
                "Поверхность выглядит более однородной из-за толстого слоя пыли.",

                name: "Deimos",
                currentPos: new Coordinate(Mars.currentPos.x + 12, 0),
                parent: Mars,
                radius: 12,
                speed: 30.4,
                size: 1,
                color: Brushes.Pink
            );

            //Запись списка спутников
            Sun.AddSatellite(Earth, Mars, Venus, Mercury);
            Earth.AddSatellite(Moon);
            Mars.AddSatellite(Phobos, Deimos);
        }
        
    }
}
