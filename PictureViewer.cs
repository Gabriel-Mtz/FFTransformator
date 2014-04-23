using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using AForge.Imaging;
using AForge.Imaging.Filters;


namespace PictureViewer
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // No code needed here for this sample.
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user chooses OK, load the 
            // picture that the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                // image file path
                textBox1.Text = openFileDialog1.FileName;

               /**

                //Here we go!
               // pictureBox1.Image
                // create complex image
                ComplexImage complexImage = ComplexImage.FromBitmap(new Bitmap(openFileDialog1.FileName));
                // do forward Fourier transformation
                complexImage.ForwardFourierTransform();
                // get complex image as bitmat
                Bitmap fourierImage = complexImage.ToBitmap();

                pictureBox1.Image = fourierImage;
                **/


                /**
                ///// Create a BitmapImage and set it's DecodePixelWidth to 200. Use  ///// 
                ///// this BitmapImage as a source for other BitmapSource objects.    /////
                BitmapImage bitmapImage = new BitmapImage();
                BitmapImage myBitmapImage = new BitmapImage();

                // BitmapSource objects like BitmapImage can only have their properties 
                // changed within a BeginInit/EndInit block.
                myBitmapImage.BeginInit();
                myBitmapImage.UriSource = new Uri(openFileDialog1.FileName, UriKind.Relative);

                // To save significant application memory, set the DecodePixelWidth or   
                // DecodePixelHeight of the BitmapImage value of the image source to the desired  
                // height or width of the rendered image. If you don't do this, the application will  
                // cache the image as though it were rendered as its normal size rather then just  
                // the size that is displayed. 
                // Note: In order to preserve aspect ratio, set DecodePixelWidth 
                // or DecodePixelHeight but not both.
                myBitmapImage.DecodePixelWidth = 200;
                myBitmapImage.EndInit();

                ////////// Convert the BitmapSource to a new format //////////// 
                // Use the BitmapImage created above as the source for a new BitmapSource object 
                // which is set to a gray scale format using the FormatConvertedBitmap BitmapSource.                                                
                // Note: New BitmapSource does not cache. It is always pulled when required.

                FormatConvertedBitmap newFormatedBitmapSource = new FormatConvertedBitmap();

                // BitmapSource objects like FormatConvertedBitmap can only have their properties 
                // changed within a BeginInit/EndInit block.
                newFormatedBitmapSource.BeginInit();

                // Use the BitmapSource object defined above as the source for this new  
                // BitmapSource (chain the BitmapSource objects together).
                newFormatedBitmapSource.Source = myBitmapImage;

                // Set the new format to Gray32Float (grayscale).
                newFormatedBitmapSource.DestinationFormat = PixelFormats.Gray32Float;
                newFormatedBitmapSource.EndInit();

                // Create Image Element
                BitmapImage myImage = new BitmapImage();
                //BitmapImage.Width = 200;
                //set image source
                myImage.BeginInit();
                myImage.SourceRect = newFormatedBitmapSource;
                myImage.EndInit();
                // Add Image to the UI
               // StackPanel myStackPanel = new StackPanel();
                //myStackPanel.Children.Add(myImage);
               // this.Content = myStackPanel;
               // pictureBox1.Image = (Image)myImage;
                 * */
              
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            pictureBox1.Image = null;

            /**
            **/
            //Here we go!
              // pictureBox1.Image
               // create complex image

           // System.Drawing.Image orig = pictureBox1.Image;

            // create grayscale filter (BT709)
            //Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            // apply the filter
           // Bitmap grayImage = filter.Apply(orig);
            
            /**
            Bitmap bbmp = new Bitmap(openFileDialog1.FileName);
               ComplexImage complexImage = ComplexImage.FromBitmap(bbmp);
               // do forward Fourier transformation
               complexImage.ForwardFourierTransform();
               // get complex image as bitmat
               Bitmap fourierImage = complexImage.ToBitmap();

               pictureBox1.Image = fourierImage;
               **/
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Show the color picker dialog box. If the user chooses OK, change the 
            // PictureBox control's background to the color the user chose. 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form. 
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box,  
            // change the PictureBox's SizeMode property to "Stretch". 
            // If the user clears the check box, change it to "Normal".
            // Choosing Stretch shows the entire image in the available space.          
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Bitmap default_image = new Bitmap(pictureBox5.Image);
            /**/
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap image = new Bitmap(System.Drawing.Image.FromFile(openFileDialog1.FileName));
            Bitmap grayImage = filter.Apply(image);
            /**/

            if (checkBox2.Checked)

                pictureBox1.Image = grayImage;

            else
                pictureBox1.Image = image;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            /**
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap image = new Bitmap(System.Drawing.Image.FromFile(openFileDialog1.FileName));
            Bitmap grayImage = filter.Apply(image);
            Bitmap BN;
            if (checkBox2.Checked)

               BN = grayImage;

            else
                BN = image;
            **/

            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap BN = filter.Apply(image);

            //Bitmap BN = new Bitmap(pictureBox1.Image);

            // create complex image
            ComplexImage complexImage = ComplexImage.FromBitmap(BN);
            //ComplexImage complexImageI = ComplexImage.FromBitmap(BN);

            // do forward Fourier transformation
            complexImage.ForwardFourierTransform();
            // get complex image as bitmat
            Bitmap fourierImage = complexImage.ToBitmap();

           // fourierImage.backwa
            complexImage.BackwardFourierTransform();
            Bitmap inverseImage = complexImage.ToBitmap();

            if (checkBox3.Checked)
                pictureBox1.Image = inverseImage;

            else
                pictureBox1.Image = fourierImage;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
