using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GitLaba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Triangle tr;
        Rectangle rec;
        Rectangle squ;
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            //Создание треугольника со случайными координатами
            Point2D p1 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p2 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p3 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            tr = new Triangle(p1, p2, p3);
            //Создание прямоугольника со случайными координатами
            Point2D p4 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p5 = new Point2D(p4.X, rnd.Next(0, (int)Scene.Height-p4.Y));
            Point2D p6 = new Point2D(rnd.Next(0, (int)Scene.Width - p4.X), p4.Y);
            Point2D p7 = new Point2D(p6.X, p5.Y);
            rec = new Rectangle(p4, p5, p6,p7);
            //Создание квадрата со случайными координатами
            Point2D p8 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p9 = new Point2D(p8.X, p8.Y+rnd.Next(0, (int)Scene.Height - p8.Y));
            Point2D p10 = new Point2D(p8.X+p9.Y-p8.Y, p8.Y);
            Point2D p11 = new Point2D(p10.X, p9.Y);
            squ = new Rectangle(p8, p9, p10, p11);
            DrawTriangle(tr);
            DrawRectangle(rec);
            DrawRectangle(squ);
        }
        public void DrawLinetr(Point2D p1, Point2D p2)
        {
            //Создание новой линии
            Line line = new Line();
            //Цвет и толщина линии
            line.Stroke = Brushes.Red;
            line.StrokeThickness = 3;
            //Установка координат линии из координат точек Point2D
            line.X1 = p1.X;
            line.Y1 = p1.Y;
            line.X2 = p2.X;
            line.Y2 = p2.Y;
            //Добавление линии в Canvas
            Scene.Children.Add(line);
        }
        public void DrawLinerec(Point2D p1, Point2D p2)
        {
            //Создание новой линии
            Line line = new Line();
            //Цвет и толщина линии
            line.Stroke = Brushes.Black;
            line.StrokeThickness = 3;
            //Установка координат линии из координат точек Point2D
            line.X1 = p1.X;
            line.Y1 = p1.Y;
            line.X2 = p2.X;
            line.Y2 = p2.Y;
            //Добавление линии в Canvas
            Scene.Children.Add(line);
        }
        public void DrawTriangle(Triangle tr)
        {
            //Отрисовка треугольника с помощью функции отрисовки линии
            DrawLinetr(tr.P1, tr.P2);
            DrawLinetr(tr.P2, tr.P3);
            DrawLinetr(tr.P3, tr.P1);
        }
        public void DrawRectangle(Rectangle rec)
        {
            //Отрисовка четырёхугольника с помощью функции отрисовки линии
            DrawLinerec(rec.P1, rec.P2);
            DrawLinerec(rec.P1, rec.P3);
            DrawLinerec(rec.P2, rec.P4);
            DrawLinerec(rec.P3, rec.P4);
        }
        private void Clear(object sender, RoutedEventArgs e)
        {
            //Очистка Canvas от всех объектов
            Scene.Children.Clear();
        }

        private void Redraw(object sender, RoutedEventArgs e)
        {
            Point2D p1 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p2 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p3 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            tr = new Triangle(p1, p2, p3);
            DrawTriangle(tr);

            Point2D p4 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p5 = new Point2D(p4.X, rnd.Next(0, (int)Scene.Height));
            Point2D p6 = new Point2D(rnd.Next(0, (int)Scene.Width), p4.Y);
            Point2D p7 = new Point2D(p6.X, p5.Y);
            rec = new Rectangle(p4, p5, p6, p7);

            Point2D p8 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p9 = new Point2D(p8.X, p8.Y + rnd.Next(0, (int)Scene.Height - p8.Y));
            Point2D p10 = new Point2D(p8.X + p9.Y - p8.Y, p8.Y);
            Point2D p11 = new Point2D(p10.X, p9.Y);
            squ = new Rectangle(p8, p9, p10, p11);
            DrawTriangle(tr);
            DrawRectangle(rec);
            DrawRectangle(squ);
        }

    }
}