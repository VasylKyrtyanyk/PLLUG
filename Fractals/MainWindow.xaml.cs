using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fractals
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private List<Polygon> polygons;
		public MainWindow()
		{
			InitializeComponent();
			polygons = new List<Polygon>();

			Loaded += MainWindow_Loaded;
		}

		private void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			polygons.Add(Triangle_);
		}

		public Point GetMid(Point p1, Point p2)
		{
			return new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
		}

		private List<Polygon> DrawTriangle(Polygon polygon)
		{
			List<Point> getPoints = polygon.Points.ToList();
			List<Polygon> triangles = new List<Polygon>();



			Point p1 = GetMid(getPoints[0], getPoints[1]);
			Point p2 = GetMid(getPoints[1], getPoints[2]);
			Point p3 = GetMid(getPoints[0], getPoints[2]);



			PointCollection pointCollection1 = new PointCollection(new List<Point> { getPoints[0], p1, p3 });
			PointCollection pointCollection2 = new PointCollection(new List<Point> { p1, getPoints[1], p2 });
			PointCollection pointCollection3 = new PointCollection(new List<Point> { p3, p2, getPoints[2] });

			triangles.Add(new Polygon { Points = pointCollection1 });
			triangles.Add(new Polygon { Points = pointCollection2 });
			triangles.Add(new Polygon { Points = pointCollection3 });


			return triangles;
		}


		private void Canvas1_OnMouseDown(object sender, MouseButtonEventArgs e)
		{
			int count = polygons.Count();

			for (int i = 0; i < count; i++)
			{
				List<Polygon> newThreePolygons = DrawTriangle(polygons[0]);

				foreach (Polygon item in newThreePolygons)
				{
					polygons.Add(item);
				}

				Polygon pol = new Polygon
				{
					Points = new PointCollection(new List<Point>
					{
						newThreePolygons[0].Points[1],
						newThreePolygons[0].Points[2],
						newThreePolygons[1].Points[2]
					})
				};

				pol.Fill = Brushes.Black;

				Canvas1.Children.Add(pol);

				polygons.Remove(polygons[0]);
			}
		}
	}
}
