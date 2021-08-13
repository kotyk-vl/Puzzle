using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();        
        }
        public int Size { get; set; } = 2;
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public string Path { get; set; } = Environment.CurrentDirectory + "..\\..\\..\\Image";
        Dictionary<int, PictureBoxE> pictureBoxes;
        Bitmap[] puzzles;
        Bitmap Btm;
        private int highestPercentageReached = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region FormSender
        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked) {
                        Size = rb_2.Checked == true ? 2 :
                            rb_3.Checked == true ? 3 :
                            rb_4.Checked == true ? 4 :
                            rb_5.Checked == true ? 5 : 6;
                        progressBar1.Value = 0;
                        label1.Text = "";
                        if (Btm != null)
                        {
                            SeparateSaveImg(Btm);
                        }
                        CreatePuzzle(Path);
                        AddPuzzleToForm();
                    }
                }
            }
            catch { }
        }
        private void BtnSelectImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog
                {
                    Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"
                };
                if (open.ShowDialog() == DialogResult.OK)
                {
                    rb_2.Enabled = rb_3.Enabled = rb_4.Enabled = rb_5.Enabled = rb_6.Enabled = true;
                    Btm = new Bitmap(open.FileName);
                    pb_img.Image = Btm;
                    SeparateSaveImg(Btm);
                    CreatePuzzle(Path);
                    AddPuzzleToForm();
                    progressBar1.Value = 0;
                    label1.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, something wrong: {ex.Message}", "Warning");
            }
        }
        private void BtnLoadPuzzle_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    CreatePuzzle(folder.SelectedPath);
                    AddPuzzleToForm();
                    progressBar1.Value = 0;
                    label1.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, something wrong: {ex.Message}", "Warning");

            }
        }
        
        private void AutoPuzzle_Click(object sender, EventArgs e)
        {
            if (pictureBoxes != null)
            {
                rb_2.Enabled = rb_3.Enabled = rb_4.Enabled = rb_5.Enabled = rb_6.Enabled = false;
                btn_load_puz.Enabled = btn_auto.Enabled = btn_sel_img.Enabled = false;

                for (int i = 0; i < pictureBoxes.Count; i++)
                {
                    pictureBoxes[i].Enabled = false;
                }
                highestPercentageReached = 0;
                label1.Text = "Wait... Puzzles are being collected automatically!";
                backgroundWorker1.RunWorkerAsync();
            }
        }
        #endregion
        #region CheckingPuzzle

        public void CheckPuzzle()
        {
            var puzzleIsMatch = pictureBoxes.Values
                .OrderBy((x => x.Number))
                .All(x => x.Location.X == (x.Width * (x.Number % Size))
                && x.Location.Y == (x.Height * (x.Number / Size))
                && x.RotateCount == 0);
            if (puzzleIsMatch)
            {
                var images = pictureBoxes.Values.OrderBy(x => x.Number).Select(x => x.Image);
                var width = pictureBoxes[0].Image.Width;
                var height = pictureBoxes[0].Image.Height;
                Btm = ConcatImage(images, width, height, Size);
                pb_img.Image = Btm;
                label1.Text = "Congratulations!!!\nYou have collected puzzles";
                MessageBox.Show("You won", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                rb_2.Enabled = rb_3.Enabled = rb_4.Enabled = rb_5.Enabled = rb_6.Enabled = true;
            }
        }
        private void AutoPuzzle(BackgroundWorker worker)
        {
             var count = pictureBoxes.Count;
             Bitmap[] bitmaps = new Bitmap[count];
             for (int i = 0; i < count; i++)
             {
                if (pictureBoxes[i].Image.Height != ImageHeight || pictureBoxes[i].Image.Width != ImageWidth)
                    pictureBoxes[i].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                bitmaps[i] = (Bitmap)pictureBoxes[i].Image;
             }
             puzzles = new Bitmap[bitmaps.Length];
             GetPuzzle(bitmaps, ref puzzles, worker);
             for (int i = 0; i < puzzles.Length; i++)
             {
                 pictureBoxes[i].Image = puzzles[i];
                 pictureBoxes[i].Number = i;
                 pictureBoxes[i].RotateCount = 0;
             }
        }
        #endregion
        private void SeparateSaveImg(Bitmap bitmap)
        {
            try
            {
                Rectangle rect;
                int btm_width = bitmap.Width / Size;
                int btm_heigh = bitmap.Height / Size;
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);
                else
                {
                    try
                    {
                        DirectoryInfo directory = new DirectoryInfo(Path);
                        var files = directory.EnumerateFiles("*.jpeg");
                        foreach (FileInfo file in files)
                        {
                            file.Delete();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                for (int i = 0; i < Size * Size; i++)
                {
                    int x = i % Size;
                    int y = i / Size;
                    rect = new Rectangle(btm_width * x, btm_heigh * y, btm_width, btm_heigh);
                    var btm = bitmap.Clone(rect, PixelFormat.DontCare);
                    btm.Save($"{Path}\\{i:d2}.jpeg");
                    btm.Dispose();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Oops, something wrong: {ex.Message}", "Warning");
                MessageBox.Show($"Oops1, something wrong: {ex.Message}", "Warning");
            }

        }
        private void CreatePuzzle(string path)
        {
            try
            {
                pictureBoxes = new Dictionary<int, PictureBoxE>();
                int key, rotate;
                string[] images = Directory.GetFiles(path, "*.jpeg");
                Size = (int)Math.Sqrt(images.Length);
                for (int i = 0; i < images.Length; i++)
                {
                    //Set properties for each puzzle
                    var pB = new PictureBoxE();
                    var image = images[i];
                    pB.Name = $"pb_puzz{i}";
                    pB.Number = i;
                    pB.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pB.SizeMode = PictureBoxSizeMode.Zoom;
                    pB.AllowDrop = true;
                    using (FileStream fileStream = new FileStream(image, FileMode.Open))
                    {
                        pB.Image = new Bitmap(fileStream);
                    }     
                    pB.Width = pnl_puzzl.Width / Size;
                    pB.Height = pnl_puzzl.Height / Size;
                    ImageWidth = pB.Image.Width;
                    ImageHeight = pB.Image.Height;
                    // Add Events
                    pB.DragEnter += new DragEventHandler(PictureBox_DragEnter);
                    pB.DragDrop += new DragEventHandler(PictureBox_DragDrop);
                    pB.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
                    //Rotate Puzzles
                    rotate = new Random().Next(0, 4);           // number of rotates
                    if (i == 0 || i == images.Length - 1)
                    //rotate = new Random().Next(3, 4);
                    rotate = 0;
                    pB.Image.RotateFlip((RotateFlipType)rotate);
                    pB.RotateCount = rotate;
                    //Mixed puzzle
                    do
                    {
                        key = new Random().Next(0, Size * Size);
                    }

                    while (pictureBoxes.ContainsKey(key));
                    pictureBoxes[key] = pB;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, something wrong: {ex.Message}", "Warning");
            }
        }
        private void AddPuzzleToForm()
        {
            try
            {
                if (pictureBoxes != null)
                {
                    pnl_puzzl.Controls.Clear();
                    for (int i = 0; i < pictureBoxes.Keys.Count; i++)
                    {
                        int x = i % Size;
                        int y = i / Size;
                        pictureBoxes[i].Location = new Point(pictureBoxes[i].Width * x, pictureBoxes[i].Height * y);
                        pnl_puzzl.Controls.Add(pictureBoxes[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, something wrong: {ex.Message}", "Warning");
            }

        }
        private Bitmap ConcatImage(IEnumerable<Image> images, int width, int height, int size)

        {
            try
            {
                var bitmap = new Bitmap(width * size, height * size);
                using (var g = Graphics.FromImage(bitmap))
                {
                    int i = 0;
                    foreach (var image in images)
                    {
                        int x = i % size;
                        int y = i / size;
                        g.DrawImage(image, new Rectangle(width * x, height * y, width, height));
                        i++;
                    }
                }
                return bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot create image because: {ex.Message}", "Warning");
                return Btm;
            }
       
        }
        #region AutoPuzzleFunction
        private double GetDifferenceColor(Color px1, Color px2)
        {
            return Math.Sqrt(
                (px1.R - px2.R) * (px1.R - px2.R) +
                (px1.G - px2.G) * (px1.G - px2.G) +
                (px1.B - px2.B) * (px1.B - px2.B));
        }
        private Color[,] GetPixels(Bitmap btm)
        {
            Color[,] pixels = new Color[btm.Height, btm.Width];
            for (int x = 0; x < btm.Width; x++)
            {
                pixels[0, x] = btm.GetPixel(x, 0);
                pixels[btm.Height - 1, x] = btm.GetPixel(x, btm.Height - 1);
            }
            for (int y = 1; y < btm.Height-1; y++)
            {
                pixels[y, 0] = btm.GetPixel(0, y);
                pixels[y, btm.Width-1] = btm.GetPixel(btm.Width - 1, y);
            }
          
            return pixels;
        }
        private double RightLeftCompare(Color[,] px1, Color[,] px2)
        {
            double difference = 0;
            int height = px1.GetLength(0);
            int width = px1.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                difference += GetDifferenceColor(px1[i, width - 1], px2[i, 0]);  
            }
            return difference;
        }
        private double BottomTopCompare(Color[,] px1, Color[,] px2)
        {
            double difference = 0;
            int height = px1.GetLength(0);
            int width = px1.GetLength(1);
            for (int i = 0; i < width; i++)
            {
                difference += GetDifferenceColor(px1[height - 1, i], px2[0, i]);
            }
            return difference;
        }
        private Bitmap GetNextRightImage(Bitmap image, List<Bitmap> images, ref double difference)
        {
            double min = Int32.MaxValue;
            Color[,] img_1 = GetPixels(image);
            Bitmap result = null;

            for (int i = 0; i < images.Count; i++)
            {
                Color[,] img_2 = GetPixels(images[i]);
                double k =  RightLeftCompare(img_1, img_2);
                if (min > k)
                {
                    result = images[i];
                    min = k;
                }
            }
            difference += min;
            return result;
        }
        private Bitmap GetNextBottomImage(Bitmap image, List<Bitmap> images, ref double difference)
        {
            double min = Int32.MaxValue;
            Color[,] img_1 = GetPixels(image);
            Bitmap result = null;

            for (int i = 0; i < images.Count; i++)
            {
                Color[,] img_2 = GetPixels(images[i]);
                double k = BottomTopCompare(img_1, img_2);
                if (min > k)
                {
                    result = images[i];
                    min = k;
                }
            }
            difference += min;
            return result;
        }
        private Bitmap GetNextRightBottomImg(Bitmap leftImage, Bitmap topImage, List<Bitmap> images, ref double difference)
        {
            double min = Int32.MaxValue;
            Color[,] img_left = GetPixels(leftImage);
            Color[,] img_top = GetPixels(topImage);
            Bitmap result = null;

            for (int i = 0; i < images.Count; i++)
            {
                Color[,] img_2 = GetPixels(images[i]);
                double leftValue = RightLeftCompare(img_left, img_2);
                double topValue = BottomTopCompare(img_top, img_2);
                double k = leftValue + topValue;
                if (min > k)
                {
                    result = images[i];
                    min = k;
                }
            }
            difference += min;
            return result;
        }
        private void GetPuzzle(Bitmap [] images, ref Bitmap [] puzzles, BackgroundWorker worker)
        {

            try
            {
                Bitmap puzzl;
                int countImg = (int)Math.Sqrt(images.Length);
                double min = Int32.MaxValue;
                for (int i = 0; i < images.Length; i++)
                {
                    double total = 0;
                    Bitmap[] temp_puzzles = new Bitmap[images.Length];
                    List<Bitmap> compare_btm = new List<Bitmap>(images);
                    temp_puzzles[0] = compare_btm[i];
                    compare_btm.RemoveAt(i);
                    int size = compare_btm.Count;
                    for (int count = 0; count < size; count++)              //Cloning images and rotate them
                    {
                        using Bitmap btm = new Bitmap(compare_btm[count]);
                        btm.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        compare_btm.Add((Bitmap)btm.Clone());
                    }
                    for (int j = 0; j < images.Length - 1; j++)
                    {

                        if (j < countImg - 1)
                        {         
                            puzzl = GetNextRightImage(temp_puzzles[j], compare_btm, ref total);
                        }
                        else if(j % countImg == countImg - 1)
                            puzzl = GetNextBottomImage(temp_puzzles[j - countImg + 1], compare_btm, ref total);
                        else
                        {
                            puzzl = GetNextRightBottomImg(temp_puzzles[j], temp_puzzles[j - countImg + 1], compare_btm, ref total);
                        }
                        temp_puzzles[j + 1] = puzzl;

                        int position = compare_btm.IndexOf(puzzl);
                        int coff = position >= (size - j) ? -1 : 1;
                        int deletePosition = position + (size - j) * coff;

                        compare_btm.RemoveAt(deletePosition);
                        compare_btm.Remove(puzzl);
                    }
                    if (min > total)
                    {
                        puzzles = temp_puzzles;
                        min = total;
                    }
                    int percentComplete = (int)((float)i / (float)(images.Length - 1) * 100);
                    if (percentComplete > highestPercentageReached)
                    {
                        highestPercentageReached = percentComplete;
                        worker.ReportProgress(percentComplete);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, something wrong: {ex.Message}", "Warning");
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }
        #endregion
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            rb_2.Enabled = rb_3.Enabled = rb_4.Enabled = rb_5.Enabled = rb_6.Enabled = true;
            btn_load_puz.Enabled = btn_auto.Enabled = btn_sel_img.Enabled = true;
            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                pictureBoxes[i].Enabled = true;
            }
            int width = pictureBoxes[0].Image.Width;
            int heiht = pictureBoxes[0].Image.Height;
            var btm = ConcatImage(puzzles, width, heiht, Size);
            if (pb_img.Image == null) 
            {
                Btm = btm;
                pb_img.Image = btm;
            }
            
            label1.Text = "Done";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            AutoPuzzle(worker);
            
        }
        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBoxE)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                rb_2.Enabled = rb_3.Enabled = rb_4.Enabled = rb_5.Enabled = rb_6.Enabled = false;
                var pb = (PictureBoxE)sender;
                pb.DoDragDrop(pb, DragDropEffects.Move);
                label1.Text = "";
                using (Bitmap btm = new Bitmap(pb.Image))
                {
                    btm.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pb.Image = (Bitmap)btm.Clone();
                    ++pb.RotateCount;
                }        
                CheckPuzzle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, something wrong: {ex.Message}", "Warning");
            }     
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {

            try
            {
                var sourcePictureBox = e.Data.GetData(typeof(PictureBoxE)) as PictureBoxE;
                var targetPictureBox = (PictureBoxE)sender;

                var tempImage = (Bitmap)sourcePictureBox.Image.Clone();
                var tempNumber = sourcePictureBox.Number;
                var rotatecount = sourcePictureBox.RotateCount;
                sourcePictureBox.Image = (Bitmap)targetPictureBox.Image.Clone();
                sourcePictureBox.Number = targetPictureBox.Number;
                sourcePictureBox.RotateCount = targetPictureBox.RotateCount;
                targetPictureBox.Image = tempImage;
                targetPictureBox.Number = tempNumber;
                targetPictureBox.RotateCount = rotatecount;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, something wrong: {ex.Message}", "Warning");
            }
        }
    }
}
