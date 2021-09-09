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
using System.Windows.Shapes;

namespace ZZ_Tests
{
    /// <summary>
    /// Interaktionslogik für DragDropTest.xaml
    /// </summary>
    public partial class DragDropTest : Window
    {
        public DragDropTest()
        {
            InitializeComponent();
            List<int> zahlen = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                zahlen.Add(i + 1);
            }

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                DragDropRow row = new DragDropRow();
                row.MouseMove += Row_MouseMove;
                row.MouseDown += Row_MouseDown;
                row.DragEnter += Row_DragEnter;
                row.DragLeave += Row_DragLeave;
                row.Drop += Row_Drop;

                int nr = rnd.Next(0, zahlen.Count);
                int zahl = zahlen[nr];
                zahlen.RemoveAt(nr);

                row.rowName.Content = $"Zeile {zahl}";
                row.AllowDrop = true;
                row.Background = i % 2 == 0 ? Brushes.Yellow : Brushes.LightBlue;
                Grid.SetRow(row, i);
                grid.Children.Add(row);
            }

        }

        private void Row_Drop(object sender, DragEventArgs e)
        {

            dragRow.BorderBrush = Brushes.Transparent;
            dragRow.BorderThickness = new Thickness(0, 0, 0, 0);
            dragRow.Background = Grid.GetRow(dragRow) % 2 == 0 ? Brushes.Yellow : Brushes.LightBlue;

        }

        private void Row_DragLeave(object sender, DragEventArgs e)
        {
            //DragDropRow row = (DragDropRow)sender;
            //row.Padding = new Thickness(0, 0, 0, 0);
        }

        private void Row_DragEnter(object sender, DragEventArgs e)
        {
            DragDropRow DDrow = (DragDropRow)sender;
            int zielRow = Grid.GetRow(DDrow);
            
            DragDropData ddd = (DragDropData)e.Data.GetData(typeof(DragDropData));
            int quellRow = Grid.GetRow(ddd.DDRow);

            if (zielRow < quellRow)
            {
                System.Diagnostics.Debug.Print($"ZielRow = {zielRow}, QuellRow= {quellRow}");

                Grid.SetRow(DDrow, zielRow + 1);
                DDrow.Background = Grid.GetRow(DDrow) % 2 == 0 ? Brushes.Yellow : Brushes.LightBlue;
                Grid.SetRow(ddd.DDRow, quellRow - 1);
            }
            else if (zielRow > quellRow)
            {
                System.Diagnostics.Debug.Print($"ZielRow = {zielRow}, QuellRow= {quellRow}");

                Grid.SetRow(DDrow, zielRow - 1);
                DDrow.Background = Grid.GetRow(DDrow) % 2 == 0 ? Brushes.Yellow : Brushes.LightBlue;
                Grid.SetRow(ddd.DDRow, quellRow + 1);
            }

        }

        Point klickPos;
        DragDropRow dragRow;

        private void Row_MouseDown(object sender, MouseButtonEventArgs e)
        {
            klickPos = e.GetPosition((DragDropRow)sender);
        }

        private void Row_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point movePos = e.GetPosition((DragDropRow)sender);
                int xDif = Math.Abs((int)(movePos.X - klickPos.X));
                int yDif = Math.Abs((int)(movePos.Y - klickPos.Y));
                if (Math.Max(xDif, yDif) > 5)
                {
                    dragRow = (DragDropRow)sender;
                    dragRow.BorderBrush = Brushes.Red;
                    dragRow.BorderThickness = new Thickness(5, 5, 5, 5);

                    dragRow.Background = Brushes.Gray;

                    DragDrop.DoDragDrop(dragRow, new DragDropData(dragRow, Grid.GetRow(dragRow)), DragDropEffects.Link);
                }
            }
        }
    }
}
