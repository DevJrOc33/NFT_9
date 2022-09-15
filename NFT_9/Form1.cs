using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



/*

//D̸̝͔͓̐̽̓è̴͇̟̼̓͋v̸̢͎̦̾̈́J̴̡͉̈́͆͑͜r̴͖͎͔̈́͒͝O̴̘͓̻̔͌͛C̵͚͕͖͑͋͠3̴͖͖̦̽͑͑3̸̘̻͙̾̾̓
╔══╗─────╔╗─╔═╦═╦═══╦═══╗
╚╗╗╠═╦═╦═╣╠╦╣║║╔╣╔═╗║╔═╗║
╔╩╝║╩╬╗║╔╣║╔╣║║╚╬╝╔╝╠╝╔╝║
╚══╩═╝╚═╩═╩╝╚═╩═╬╗╚╗╠╗╚╗║
────────────────║╚═╝║╚═╝║
//D̸̝͔͓̐̽̓è̴͇̟̼̓͋v̸̢͎̦̾̈́J̴̡͉̈́͆͑͜r̴͖͎͔̈́͒͝O̴̘͓̻̔͌͛C̵͚͕͖͑͋͠3̴͖͖̦̽͑͑3̸̘̻͙̾̾̓

*/


namespace NFT_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //main to make image full
            //export tranparent .png from photoshop 
            //500 500 
            Bitmap bitmap = new Bitmap(670, 670);


            //layer_one
            Bitmap layer_one1 = new Bitmap("C:\\Users\\Anon\\Desktop\\nft_algo\\B_1.png");
            Bitmap layer_one2 = new Bitmap("C:\\Users\\Anon\\Desktop\\nft_algo\\B_2.png");
            Bitmap layer_one3 = new Bitmap("C:\\Users\\Anon\\Desktop\\nft_algo\\B_3.png");
            Bitmap layer_one4 = new Bitmap("C:\\Users\\Anon\\Desktop\\nft_algo\\B_4.png");

            //layer_two
            Bitmap layer_two1 = new Bitmap("C:\\Users\\Anon\\Desktop\\nft_algo\\L_1.png");
            Bitmap layer_two2 = new Bitmap("C:\\Users\\Anon\\Desktop\\nft_algo\\L_2.png");
            Bitmap layer_two3 = new Bitmap("C:\\Users\\Anon\\Desktop\\nft_algo\\L_3.png");
            Bitmap layer_two4 = new Bitmap("C:\\Users\\Anon\\Desktop\\nft_algo\\L_4.png");

            //layer_three
            Bitmap layer_three1 = new Bitmap("C:\\Users\\Anon\\Desktop\\nft_algo\\F_1.png");
            Bitmap layer_three2 = new Bitmap("C:\\Users\\Anon\\Desktop\\nft_algo\\F_2.png");
            Bitmap layer_three3 = new Bitmap("C:\\Users\\Anon\\Desktop\\nft_algo\\F_3.png");
            Bitmap layer_three4 = new Bitmap("C:\\Users\\Anon\\Desktop\\nft_algo\\F_4.png");




            //while loop
            int i =0;


            //set number of images to create
            while (i < 50)
            {


                //to introduce propbabilities just add more number of trates so that when 
                //randomly selected they are fractioned



                //layer one 
                /////////////////////////////////////////////////
                var random1 = new Random();
                var list1 = new List<Bitmap> { 
                    layer_one1,
                    layer_one2,
                    layer_one3,
                    layer_one4
                };
                int index1 = random1.Next(list1.Count);
                //secret merger sauce
                Image merged1 = new Bitmap(bitmap.Width, bitmap.Height);
                using (Graphics gr1 = Graphics.FromImage(merged1))
                {
                    gr1.DrawImage(list1[index1], new Point(0, 0));
                }



                //layer_two
                /////////////////////////////////////////////////
                var random2 = new Random();
                var list2 = new List<Bitmap> { 
                    layer_two1,
                    layer_two2,
                    layer_two3,
                    layer_two4
                };
                int index2 = random2.Next(list2.Count);
                //secret merger sauce
                Image merged2 = new Bitmap(bitmap.Width, bitmap.Height);
                using (Graphics gr2 = Graphics.FromImage(merged2))
                {
                    gr2.DrawImage(list2[index2], new Point(0, 0));
                }



                //layer_three
                /////////////////////////////////////////////////
                var random3 = new Random();
                var list3 = new List<Bitmap> { 
                    layer_three1,
                    layer_three2,
                    layer_three3,
                    layer_three4
                };
                int index3 = random3.Next(list3.Count);
                //secret merger sauce
                Image merged3 = new Bitmap(bitmap.Width, bitmap.Height);
                using (Graphics gr3 = Graphics.FromImage(merged3))
                {
                    gr3.DrawImage(list3[index3], new Point(0, 0));
                }





                //output
                Image output = new Bitmap(bitmap.Width, bitmap.Height);
                using (Graphics grf = Graphics.FromImage(output))
                {
                    grf.DrawImage(merged1, new Point(0, 0));
                    grf.DrawImage(merged2, new Point(0, 0));
                    grf.DrawImage(merged3, new Point(0, 0));


                    merged1.Dispose();
                    merged2.Dispose();
                    merged3.Dispose();


                }

                //Display Button
                pictureBox1.Image = output;

                //Export Button
                output.Save("C:\\Users\\Anon\\Desktop\\nft_algo1\\" + "\\export" + i + ".png");

                merged1.Dispose();
                merged2.Dispose();
                merged3.Dispose();

                

                //JSON serializing 
                using (StreamWriter sw = new StreamWriter("C:\\Users\\Anon\\Desktop\\nft_algo1\\" + "\\export" + i + ".txt"))
                {

                    sw.WriteLine("{");
                    sw.WriteLine("\"attributes\": [{");

                    //layer_one
                    if (index1 == 0)
                    {
                        sw.WriteLine("\"trait_type\": \"Background\", \"value\": \"Space 1\"");
                    }
                    else if (index1 == 1)
                    {
                        sw.WriteLine("\"trait_type\": \"Background\", \"value\": \"Space 2\"");
                    }
                    else if (index1 == 2)
                    {
                        sw.WriteLine("\"trait_type\": \"Background\", \"value\": \"Space 3\"");
                    }
                    else if (index1 == 3)
                    {
                        sw.WriteLine("\"trait_type\": \"Background\", \"value\": \"Space 4\"");
                    }

                    sw.WriteLine("}, {");

                    //layer_two
                    if (index2 == 0)
                    {
                        sw.WriteLine("\"trait_type\": \"Head\", \"value\": \"Head 1\"");
                    }
                    else if (index2 == 1)
                    {
                        sw.WriteLine("\"trait_type\": \"Head\", \"value\": \"Head 2\"");
                    }
                    else if (index2 == 2)
                    {
                        sw.WriteLine("\"trait_type\": \"Head\", \"value\": \"Head 3\"");
                    }
                    else if (index2 == 3)
                    {
                        sw.WriteLine("\"trait_type\": \"Head\", \"value\": \"Head 4\"");
                    }

                    sw.WriteLine("}, {");

                    //layer_3
                    if (index3 == 0)
                    {
                        sw.WriteLine("\"trait_type\": \"Smile\", \"value\": \"Smile 1\"");
                    }
                    else if (index3 == 1)
                    {
                        sw.WriteLine("\"trait_type\": \"Smile\", \"value\": \"Smile 2\"");
                    }
                    else if (index3 == 2)
                    {
                        sw.WriteLine("\"trait_type\": \"Smile\", \"value\": \"Smile 3\"");
                    }
                    else if (index3 == 3)
                    {
                        sw.WriteLine("\"trait_type\": \"Smile\", \"value\": \"Smile 4\"");
                    }

                    sw.WriteLine("}, {");

                    //invisible trait
                    sw.WriteLine("\"trait_type\": \"Invisible\", \"value\": \"Invisible Trate\"");

                    sw.WriteLine("}");
                    sw.WriteLine("]");
                    sw.WriteLine("}");



                }

                i++;



            }

        }
    }
}

