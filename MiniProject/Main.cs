using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace MiniProject
{
    public partial class Main : Form
    {
        //GUI Variables

        ListBox SearchResults = new ListBox();
        TextBox SearchBar = new TextBox();
        Button SearchButton = new Button();


        //array to store nutrient info from file
        static FoodItem[] FoodArray = new FoodItem[2534];
        
        //array to store heading from file (if needed)
        static string[] headings = new string[9];



        //Constants
        const int test = 5;



        public Main()
        {
            InitializeComponent();
            OpenFile();
            GUISetup();
        }

        //Method for the User Interface Setup
        public void GUISetup()
        {
            //SearchBar Design
            SearchBar.Location = new Point(20, 40);
            SearchBar.Size = new Size(350, 20);
            SearchBar.ForeColor = Color.Navy;
            SearchBar.BackColor = Color.LightSteelBlue;
            Controls.Add(SearchBar);

            //SearchButton Design
            SearchButton.Location = new Point(375, 40);
            SearchButton.Size = new Size(80, 20);
            SearchButton.Text = "Search";
            SearchButton.Click += new EventHandler(SearchButton_Click);
            Controls.Add(SearchButton);

            //ListBox Results Design
        }

        void SearchButton_Click(object sender, EventArgs e)
        {
            // When the button is clicked,
            // change the button text, and disable it.

            Button clickedButton = (Button)sender;
            clickedButton.Text = "Yeet";
            clickedButton.Enabled = false;
        }





        static void OpenFile()
        {
            //Open Nutrient file
            string filename = "Nutrientfile.txt";
            StreamReader reader = File.OpenText(filename);
            string[] line = new String[9];
            int i = 0;
            Console.Write(".... reading file");
            //Load data into an array
            while (reader.Peek() != -1)
            {
                //read in line and split by tab
                line = reader.ReadLine().Split('\t');
                /*
                                nutrientArray[i, 0] = line[0];
                                nutrientArray[i, 1] = line[1];
                                nutrientArray[i, 2] = line[2];
                                nutrientArray[i, 3] = line[3];
                                nutrientArray[i, 4] = line[4];
                                nutrientArray[i, 5] = line[5];
                                nutrientArray[i, 6] = line[6];
                                nutrientArray[i, 7] = line[7];
                                nutrientArray[i, 8] = line[8];
                */
                if (i > 0)
                    FoodArray[i - 1] = new FoodItem(line);

                i++;
            }

            reader.Close();
            Console.WriteLine(".... file read");
            Console.WriteLine();
/*
            //store the headings into the "headings" Array
            for (i = 0; i < 9; i++)
            {
                headings[i] = nutrientArray[0, i];
            }
*/
            for (i = 0; i < FoodArray.Length - 1; i++)
            {
                Console.WriteLine(FoodArray[i].print());
                
            }
        }



    }

    public class Calculate
    {
        public void CalcFoodValues()
        {


        }
    }
}
