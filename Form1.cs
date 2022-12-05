﻿using SimplePaint.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        Graphics g;
        Color color;
        SolidBrush brush;
        Shape shape;
        RectangleShape rec;
        CircleShape cir;
        TriangleShape tri;
        HexagonShape hex;
        List<Shape> shapeList; // oluşturulan her şekil bir nesne olarak generic bir yapıda tutuldu
        Point MouseDownStartingLocation; // çizilen şeklin başlangıç konumu
        Point MouseDownEndingLocation; // çizilen şeklin bitiş konumu (mouse bırakıldığı nokta)
        Point newLocation; // taşıma işlemlerinde yeni konumu belirlemek için

        // hangi nesnenin çizildiğini belirlemek için 
        bool IsMouseDownRectange = false;
        bool IsMouseDownCircle = false;
        bool IsMouseDownTriangle = false;
        bool IsMouseDownHexagon = false;

        bool paint = false; // çizim işleminin yapılıp yapılmadığını anlamak için

        // şekil işlemlerinde hangi olayın aktif olduğunu belirlemek için 
        bool IsMouseChoose = false;
        bool IsMouseDownChoose = false;
        bool IsMouseDownDelete = false;
        bool IsMouseChangedColor = false;
        bool Moving = false;
        bool ColorChange = false;
        bool IsDelete = false;

        enum _Shapes // karışıklık olmaması adına hangi şeklin çizildiğini belirlemek için enum yapısı tutuldu
        {
            _rectangle = 1,
            _circle,
            _triangle,
            _hexagon

        }
        _Shapes _shape;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = drawingArea.CreateGraphics();
            shapeList = new List<Shape>();
            errorLbl.Visible = false;
            //  rectangle.BorderStyle = BorderStyle.Fixed3D;
            _shape = 0;
        }

        #region Tanımlanan Fonksiyonlar
        private void AllPictureBoxRemoveBorder(GroupBox groupBx) // groupBox içinde bir buton seçildiğinde kalan butonların pasif yapılması işlemini yapıyor.
        {
            foreach (var item in groupBx.Controls.OfType<PictureBox>())
                item.BorderStyle = BorderStyle.None;
        }

        private void ColorButtonClick(Color color, PictureBox pictureBox) // renk seçildiğinde seçilen rengi alma ve ilgili butonu aktif, diğperini pasif yapma işlemini yapıyor
        {
            brush = new SolidBrush(color);
            IsMouseChangedColor = true;
            AllPictureBoxRemoveBorder(groupBox2);
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void CreateShape(Shape shape)
        {

            shape.SetCornerPoints();
            shapeList.Add(shape);
            if (shape is CircleShape)
                g.FillEllipse(shape.BrushColor, shape.CornerPoints[0].X, shape.CornerPoints[0].Y, shape.Width, shape.Height);
            else
                g.FillPolygon(shape.BrushColor, shape.CornerPoints);

        }

        #region Dosya İşlemleri için Fonksiyonlar
        public void ExportToTextFile(List<Shape> list) // nesneleri bir txt olarak kaydeder
        {
            SaveFileDialog save = new SaveFileDialog(); // savedialog ekranını açma
            save.OverwritePrompt = false; // aynı isimde bir dosya varsa üzerine yazmaz onay mesajı çıkar
            save.CreatePrompt = true; // aynı isimde dosya yoksa yine onay mesajı çıkar
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // hani dizinde açılacağı
            save.Title = "Txt"; // dialog penceresinin başlığı
            save.DefaultExt = "txt"; // varsayılan dosya uzantısı
            save.Filter = "txt Dosyaları|*.txt"; //dialog ekranında görebileceğimiz uzantılar
                                                 // save.ShowDialog();
            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(save.FileName);
                    foreach (var item in list)
                    {
                        sw.WriteLine("{0},{1},{2},{3},{4},{5}", item.ToString(), item.BrushColor.Color.Name, item.LocationStarting.X, item.LocationStarting.Y,
                            item.LocationEnding.X, item.LocationEnding.Y);
                    }
                    sw.Close();
                }

                save.ShowDialog();
            }
            catch (Exception e)
            {
                errorLbl.Visible = true;
                errorLbl.Text = ("İşlem başarısız: " + e.Message);
            }
        }
        public string ImportToTextFile() // text dosyasını okur
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // hani dizinde açılacağı
            file.Filter = "txt Dosyaları|*.txt";
            file.RestoreDirectory = true; // bu kod ile her açıldığında açılan bir önceki klasörü açacaktır. (anlamadım)
                                          //  file.CheckFileExists = false;
                                          // bu kod dosya adı kısmına bir isim yazdığınızda dosya var mı yok mu kontrolünü yapar.
            file.Title = "Txt";
            string filePath = string.Empty;

            if (file.ShowDialog() == DialogResult.OK) // dosya seçildi mi kontrolü
                filePath = file.FileName;

            file.ShowDialog(); // ekranı açma
            return filePath;

        }
        public void FileReadingAndDrawing(string filePath)
        {
            Color colorObject;
            Point locationStartingObject;
            Point locationEndingObject;
            try
            {
                StreamReader sr = new StreamReader(filePath);
                string line = sr.ReadLine();
                string[] phrases;
                while (line != null)
                {
                    phrases = line.Split(',');

                    colorObject = Color.FromName(phrases[1]);
                    locationStartingObject = new Point(Convert.ToInt32(phrases[2]), Convert.ToInt32(phrases[3]));
                    locationEndingObject = new Point(Convert.ToInt32(phrases[4]), Convert.ToInt32(phrases[5]));

                    if (phrases[0] == "RectangleShape")
                    {
                        Shape shapeObject = new RectangleShape(locationStartingObject, locationEndingObject, colorObject);
                        CreateShape(shapeObject);

                    }
                    else if (phrases[0] == "CircleShape")
                    {
                        Shape shapeObject = new CircleShape(locationStartingObject, locationEndingObject, colorObject);
                        CreateShape(shapeObject);
                    }
                    else if (phrases[0] == "TriangleShape")
                    {
                        Shape shapeObject = new TriangleShape(locationStartingObject, locationEndingObject, colorObject);
                        CreateShape(shapeObject);
                    }
                    else if (phrases[0] == "HexagonShape")
                    {
                        Shape shapeObject = new HexagonShape(locationStartingObject, locationEndingObject, colorObject);
                        CreateShape(shapeObject);
                    }

                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                errorLbl.Text = "İşlem Başarısız: " + e.Message;
            }
        }
        #endregion

        #endregion

        #region Çizim Şekli
        private void rectangle_MouseClick(object sender, MouseEventArgs e) // rectange nesnesine tıklandığında
        {
            _shape = _Shapes._rectangle; // nesnenin rectangle olacağı belirleniyor

            // sadece seçilen şekil aktif yapılıyor
            AllPictureBoxRemoveBorder(groupBox1);
            rectangle.BorderStyle = BorderStyle.Fixed3D;
        }

        private void circle_MouseClick(object sender, MouseEventArgs e)
        {
            _shape = _Shapes._circle;
            AllPictureBoxRemoveBorder(groupBox1);
            circle.BorderStyle = BorderStyle.Fixed3D;
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            _shape = _Shapes._triangle;
            AllPictureBoxRemoveBorder(groupBox1);
            triangle.BorderStyle = BorderStyle.Fixed3D;
        }

        private void hexagon_Click(object sender, EventArgs e)
        {
            _shape = _Shapes._hexagon;
            AllPictureBoxRemoveBorder(groupBox1);
            hexagon.BorderStyle = BorderStyle.Fixed3D;
        }
        #endregion

        #region Çizim Alanı Mouse İşlemleri

        private void drawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            // çizdirme, seçim olmadan, sadece nesneyi seçerek
            if (e.Button == MouseButtons.Left && !paint && !IsMouseChoose && IsDelete == false && !IsMouseDownChoose && !IsMouseDownDelete)
            {
                paint = true;
                if (IsMouseDownRectange == false && _shape == _Shapes._rectangle)
                {
                    MouseDownStartingLocation = e.Location;
                    IsMouseDownRectange = true;
                }
                if (IsMouseDownCircle == false && _shape == _Shapes._circle)
                {
                    MouseDownStartingLocation = e.Location;
                    IsMouseDownCircle = true;

                }
                if (IsMouseDownTriangle == false && _shape == _Shapes._triangle)
                {
                    MouseDownStartingLocation = e.Location;
                    IsMouseDownTriangle = true;
                }
                if (IsMouseDownHexagon == false && _shape == _Shapes._hexagon)
                {
                    MouseDownStartingLocation = e.Location;
                    IsMouseDownHexagon = true;
                }
            }

            // artık seçim basılıysa, nesneyi taşımak için
            if (e.Button == MouseButtons.Left && !IsMouseChoose && IsMouseDownChoose && !IsMouseChangedColor && !IsMouseDownDelete && !paint && !Moving)
            {
                foreach (var item in shapeList)
                {
                    //  shape = item;
                    if ((item.X < e.X && e.X < item.X + item.Width) && (item.Y < e.Y && e.Y < item.Y + item.Height))
                    {
                        shape = item;
                        newLocation = e.Location;
                        IsMouseChoose = true;
                        Moving = true;
                    }
                }
            }

            // seçilen nesnenin rengini değiştirme
            if (e.Button == MouseButtons.Left && IsMouseDownChoose && shapeList.Count != 0 && !paint && !IsMouseDownDelete && IsMouseChangedColor)
            {
                foreach (var item in shapeList)
                {
                    if ((item.X < e.X && e.X < item.X + item.Width) && (item.Y < e.Y && e.Y < item.Y + item.Height))
                        shape = item;
                }

            }

            // silme
            if (e.Button == MouseButtons.Left && IsDelete && shapeList.Count != 0 && !paint && !IsMouseDownDelete && !IsMouseChangedColor)
            {
                foreach (var item in shapeList)
                {
                    if ((item.X < e.X && e.X < item.X + item.Width) && (item.Y < e.Y && e.Y < item.Y + item.Height))
                        shape = item;
                }

            }

            //// seçili nesnenin etrafını işaretleme -- çalışmıyor
            //if (e.Button == MouseButtons.Left && IsMouseDownChoose && !Moving && shapeList.Count != 0 && !paint && !IsMouseDownDelete && !IsMouseChangedColor)
            //{
            //    foreach (var item in shapeList)
            //    {
            //        if ((item.X < e.X && e.X < item.X + item.Width) && (item.Y < e.Y && e.Y < item.Y + item.Height))
            //        {
            //            shape = item;
            //            Color c = Color.FromArgb(150, 0, 0, 0);
            //            SolidBrush sb = new SolidBrush(c);

            //            g.FillRectangle(sb, item.X, item.Y, item.Width, item.Height);

            //        }
            //    }
            //    IsMouseDownChoose = false;
            //    chooseBtn.BorderStyle = BorderStyle.None;
            //}

            // nesnenin renginin değişmesi için nesneyi taşıma
            // basıldıysa ve renk değiştirme aktifse

        }
        private void drawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            // nesneyi oluşturma
            if (e.Button == MouseButtons.Left && paint && !IsMouseChoose && !IsMouseDownChoose && !IsMouseDownDelete)
                MouseDownEndingLocation = e.Location;

            // nesneyi taşıma
            if (e.Button == MouseButtons.Left && IsMouseChoose && Moving && IsMouseDownChoose && !IsMouseChangedColor && !IsMouseDownDelete && !paint)
            {
                drawingArea.Invalidate(new Rectangle(shape.X, shape.Y, shape.Width, shape.Height));
                drawingArea.Update();
            }
        }
        private void drawingArea_MouseUp(object sender, MouseEventArgs e) /////////////////////// --> sadece bir kere tıkladığımda girdi
        {
            // nesneyi oluşturma
            if (e.Button == MouseButtons.Left && paint && !IsMouseChoose && !IsMouseDownChoose && !IsMouseDownDelete)
            {
                paint = false;
                if (MouseDownEndingLocation != MouseDownStartingLocation && _shape == _Shapes._rectangle)
                {
                    rec = new RectangleShape(MouseDownStartingLocation, MouseDownEndingLocation);
                    if (IsMouseChangedColor)
                        rec.BrushColor = brush;

                    CreateShape(rec);
                    IsMouseDownRectange = false;
                }
                if (MouseDownEndingLocation != MouseDownStartingLocation && _shape == _Shapes._circle)
                {
                    cir = new CircleShape(MouseDownStartingLocation, MouseDownEndingLocation);
                    if (IsMouseChangedColor)
                        cir.BrushColor = brush;

                    CreateShape(cir);
                    IsMouseDownCircle = false;
                }
                if (MouseDownEndingLocation != MouseDownStartingLocation && _shape == _Shapes._triangle)
                {
                    tri = new TriangleShape(MouseDownStartingLocation, MouseDownEndingLocation);
                    if (IsMouseChangedColor)
                        tri.BrushColor = brush;

                    CreateShape(tri);
                    IsMouseDownTriangle = false;
                }
                if (MouseDownEndingLocation != MouseDownStartingLocation && _shape == _Shapes._hexagon)
                {
                    hex = new HexagonShape(MouseDownStartingLocation, MouseDownEndingLocation);
                    if (IsMouseChangedColor)
                        hex.BrushColor = brush;

                    CreateShape(hex);
                    IsMouseDownHexagon = false;
                }
                MouseDownEndingLocation = new Point(0, 0);
                MouseDownStartingLocation = new Point(0, 0);
                AllPictureBoxRemoveBorder(groupBox1);
                AllPictureBoxRemoveBorder(groupBox2);
            }

            // taşıma işlemi 
            if (e.Button == MouseButtons.Left && IsMouseChoose && IsMouseDownChoose && !IsMouseChangedColor && !IsMouseChangedColor && !IsMouseDownDelete && !paint) ///// rectangle oluştu onu seçtim çalıştı !!!!!!!!1
            {
                int _x = 0, _y = 0, _w = 0, _h = 0;
                Color _c = Color.Black;

                var _temp = shapeList.Where(x => x == shape).ToList();
                foreach (var item in _temp)
                {
                    _x = item.X;
                    _y = item.Y;
                    _w = item.Width;
                    _h = item.Height;
                    _c = item.BrushColor.Color;
                }
                Point newP = new Point((e.X - (newLocation.X - _x)), (e.Y + (_y - newLocation.Y)));
                Point newP2 = new Point(newP.X + _w, newP.Y + _h);
                shapeList.Remove(shapeList.SingleOrDefault(x => x == shape));

                if (shape is RectangleShape)
                {
                    RectangleShape ps = new RectangleShape(newP, newP2, _c);
                    ps.SetCornerPoints();
                    shapeList.Add(ps);
                    g.FillPolygon(ps.BrushColor, ps.CornerPoints);
                }
                if (shape is TriangleShape)
                {
                    TriangleShape ts = new TriangleShape(newP, newP2, _c);
                    ts.SetCornerPoints();
                    shapeList.Add(ts);
                    g.FillPolygon(ts.BrushColor, ts.CornerPoints);
                }
                if (shape is CircleShape)
                {
                    CircleShape cs = new CircleShape(newP, newP2, _c);
                    cs.SetCornerPoints();
                    shapeList.Add(cs);
                    g.FillEllipse(cs.BrushColor, cs.CornerPoints[0].X, cs.CornerPoints[0].Y, cs.Width, cs.Height);
                }
                if (shape is HexagonShape)
                {
                    HexagonShape hs = new HexagonShape(newP, newP2, _c);
                    hs.SetCornerPoints();
                    shapeList.Add(hs);
                    g.FillPolygon(hs.BrushColor, hs.CornerPoints);
                }

                IsMouseChoose = false;
                Moving = false;
                IsMouseDownChoose = false; ///////
                shape = null;
                AllPictureBoxRemoveBorder(shapeGrpbx);
            }

            // renk değiştime
            if (e.Button == MouseButtons.Left && IsMouseDownChoose && shape != null && IsMouseChangedColor && !IsMouseDownDelete && !paint)
            {


                var _temp = shapeList.Where(x => x == shape);
                foreach (var item in _temp)
                {
                    item.BrushColor = brush;
                }

                drawingArea.Invalidate(new Rectangle(shape.X, shape.Y, shape.Width, shape.Height));
                drawingArea.Update();
                if (shape is CircleShape)
                {
                    g.FillEllipse(cir.BrushColor, shape.CornerPoints[0].X, shape.CornerPoints[0].Y, shape.Width, shape.Height);
                }
                else
                {
                    g.FillPolygon(brush, shape.CornerPoints);
                }

                //  drawingArea.Update();

                IsMouseDownChoose = false;
                chooseBtn.BorderStyle = BorderStyle.None;

                shape = null;
                IsMouseChangedColor = false;
                IsMouseDownChoose = false;
                //    ColorChange = true;
                AllPictureBoxRemoveBorder(groupBox1);
                AllPictureBoxRemoveBorder(groupBox2);
            }

            // silme
            if (e.Button == MouseButtons.Left && !IsMouseDownDelete && IsDelete && !IsMouseDownChoose && !IsMouseChoose && !paint && !Moving && shape != null)
            {
                drawingArea.Invalidate(new Rectangle(shape.X, shape.Y, shape.Width, shape.Height)); //null dönebilir
                drawingArea.Update();
                shapeList.Remove(shapeList.SingleOrDefault(x => x == shape));
                shape = null;
                IsMouseDownChoose = false;
                IsDelete = false;
                chooseBtn.BorderStyle = BorderStyle.None;
                System.Threading.Thread.Sleep(500);
                deleteBtn.BorderStyle = BorderStyle.None;
            }
        }
        #endregion

        #region Renk Seçimi
        private void red_MouseClick(object sender, MouseEventArgs e)
        {
            ColorButtonClick(Color.Red, red);
        }
        private void blue_MouseClick(object sender, MouseEventArgs e)
        {
            ColorButtonClick(Color.Blue, blue);
        }
        private void green_MouseClick(object sender, MouseEventArgs e)
        {
            ColorButtonClick(Color.Green, green);
        }
        private void orange_MouseClick(object sender, MouseEventArgs e)
        {
            ColorButtonClick(Color.Orange, orange);
        }
        private void black_MouseClick(object sender, MouseEventArgs e)
        {
            ColorButtonClick(Color.Black, black);
        }
        private void yellow_MouseClick(object sender, MouseEventArgs e)
        {
            ColorButtonClick(Color.Yellow, yellow);
        }
        private void purple_MouseClick(object sender, MouseEventArgs e)
        {
            ColorButtonClick(Color.Purple, purple);
        }
        private void burgundy_MouseClick(object sender, MouseEventArgs e)
        {
            ColorButtonClick(Color.Brown, burgundy);
        }
        private void white_MouseClick(object sender, MouseEventArgs e)
        {
            ColorButtonClick(Color.White, white);
        }
        #endregion

        #region Şekil İşlemleri
        private void newPageBtn_Click(object sender, EventArgs e)
        {
            shapeList.Clear();
            drawingArea.Invalidate();
            drawingArea.Update();
            MouseDownStartingLocation = new Point(0, 0);
            MouseDownEndingLocation = new Point(0, 0);
        }
        private void chooseBtn_MouseClick(object sender, MouseEventArgs e)
        {
            IsMouseDownChoose = true;
            IsMouseDownDelete = false;
            chooseBtn.BorderStyle = BorderStyle.Fixed3D;
            deleteBtn.BorderStyle = BorderStyle.None;
        }
        private void deleteBtn_MouseClick(object sender, MouseEventArgs e)
        {
            IsDelete = true;
            deleteBtn.BorderStyle = BorderStyle.Fixed3D;
        }

        #endregion

        #region Dosya İşlemleri
        private void exportBtn_Click(object sender, EventArgs e)
        {
            exportBtn.BorderStyle = BorderStyle.Fixed3D;
            importBtn.BorderStyle = BorderStyle.None;
            ExportToTextFile(shapeList);
        }
        private void importBtn_Click(object sender, EventArgs e)
        {
            importBtn.BorderStyle = BorderStyle.Fixed3D;
            exportBtn.BorderStyle = BorderStyle.None;
            string filePath = ImportToTextFile();
            FileReadingAndDrawing(filePath);
        }
        #endregion
    }
}
