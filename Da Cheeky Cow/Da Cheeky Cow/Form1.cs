/* Student Name: Bibin Sunny Sebastian
 * Student ID: 18230329
 * Date: 28/11/2018
 * Assignment:5
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Da_Cheeky_Cow
{
    public partial class Form1 : Form
    {
        
        readonly static decimal[,] MealCost =
        {
            {1.23m, 2.40m, 3.49m, 2.19m, 3.99m, 7.89m, 3.45m, 3.67m, 4.55m, 5.00m, 1.23m, 3.45m},
            {5.69m, 2.90m, 3.99m, 3.12m, 4.49m, 8.89m, 3.75m, 3.97m, 5.00m, 5.50m, 2.23m, 3.95m},
            {6.83m, 3.40m, 4.49m, 4.05m, 5.50m, 8.50m, 4.25m, 4.50m, 5.36m, 6.00m, 3.23m, 4.45m},
            {6.99m, 3.59m, 4.99m, 4.49m, 6.51m, 8.11m, 4.75m, 5.03m, 5.72m, 6.50m, 4.23m, 4.95m},
            {9.99m, 3.78m, 5.49m, 4.93m, 7.52m, 7.72m, 5.25m, 5.56m, 6.08m, 7.00m, 5.23m, 5.45m}
        };         // 2D Array to store price value of each item in a variable
        readonly static string[] MealtypeOptions = {"Full Irish","Irish Grill","Belmullet Grill","Curry Special","Irish Stew","Student Stew","Bacon & Cabbage",
                                                "Colcannon","Boxty Special","Atlantic Way","Coddle","Snack Box" };     // 2D Array to store meal item value of each item in a variable
        readonly static string[] MealsizeOptions = { "Leprechaun", "Child", "Adult", "Student", "Cúchulainn" };        // 2D Array to store meal size value in a variable
        //defining the variables
        decimal price;
        decimal totalMealcost     = 0.0m;
        decimal fulltotalMealcost = 0.0m;
        int quantity = 0;
        int k = 0;
        List<List<string>> itemOrders = new List<List<string>>();            //List inside list used in the event of cancellation

        public Form1()
        {
            InitializeComponent();
            this.Text = "Da Cheeky Cow";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hide the groupboxes initially
            summaryListbox.Visible   = false;
            tableLayoutPanel.Visible = false;
            priceLabel.Visible       = false;
            finalLabel.Visible       = false;
            confirmButton.Enabled    = false;
            clearButton.Enabled      = false;
            submitButton.Enabled     = false;
            exitButton.Enabled       = false;
        }

        // Defining a function, which will fill the value for price textbox automatically based on the selection from Meal type and meal size listboxes
        private void Calculatedpricevalue()
        {
            //assigning current position value to the variables
            int MealTypeIndex = itemListbox.SelectedIndex;      //Index value stored to the variable.
            int MealSizeIndex = typeListbox.SelectedIndex;      //Index value stored to the variable.

            if (MealTypeIndex != -1)
            {
                if (MealSizeIndex != -1)
                {
                    price             = MealCost[MealSizeIndex, MealTypeIndex];
                    PriceTextbox.Text = price.ToString("c", new CultureInfo("en-FR")); // assigning the array value to the text box
                }
            } 
        }

        private void itemListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculatedpricevalue();         // Calling the function defined above inside list box
        }

        private void typeListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculatedpricevalue();         // Calling the function defined above inside list box
        }

        // Defining a Function that add current selection from item type and item size listbox to the summary listbox. 
        private void TrackStockBalance()
        {
            Random rnd     = new Random();
            quantity       = int.Parse(QtyTextbox.Text);
            int transactNo = rnd.Next();
            transactNo     = rnd.Next(100000, 999999);     // generates a 6 digit random no which serves the purpose for transaction no
            if (summaryListbox.Items.Contains(transactNo))
            {
                summaryListbox.Items.Add(transactNo);
            }

            string DccStockLocation = "DCC Stock.csv";      //defining the csv file's path
            //To read the stock file and store its values to list
            StreamReader LineRead   = new StreamReader(DccStockLocation);  
            var ReadLine = new List<string[]>();
            int DCCstockRow = 0;
            while (!LineRead.EndOfStream)
            {
                string[] TempLine = LineRead.ReadLine().Split(',');
                ReadLine.Add(TempLine);
                DCCstockRow++;
            }
            LineRead.Close();
            var StoremyData   = ReadLine.ToArray(); //The collected values to be stored in an array.
            int MealTypeIndex = itemListbox.SelectedIndex;
            int MealSizeIndex = typeListbox.SelectedIndex;
            
            // Condition when the quantity entered by the user is greater than the available stock

            if (quantity > int.Parse(StoremyData[MealSizeIndex + 1][MealTypeIndex + 1]))
            {
                //Event handling which displayes the available stock and suggesting the user to select lower quantity
                MessageBox.Show("The current available stock for this item is " + StoremyData[MealSizeIndex + 1][MealTypeIndex + 1] + ". Please select a lower quantity !", "Insufficient Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                QtyTextbox.Focus();
                QtyTextbox.Text = StoremyData[MealSizeIndex + 1][MealTypeIndex + 1]; // available stock level to get automatically pre-entered for processing
                QtyTextbox.SelectAll();
            }
            else
            {
                //Store the correspondant value of every selection into a new list under k that was defined globally, to save all the orders made in order to update the stock file whenever required.
                itemOrders.Add(new List<string>());
                itemOrders[k].Add(StoremyData[MealSizeIndex + 1][MealTypeIndex + 1]); ///Stores the value from the stock file to the list
                itemOrders[k].Add((MealSizeIndex + 1).ToString()); //Stores the position of meal size selected by user
                itemOrders[k].Add((MealTypeIndex + 1).ToString()); //Stores the position of meal type selected by user
                k++;
                //logic for getting total cost for selected product
                totalMealcost     = price * quantity;
                fulltotalMealcost = fulltotalMealcost + totalMealcost;
                
                displaylabel.Text = "The running total is " + totalMealcost.ToString("c", new CultureInfo("en-FR"));

                // displaying the corresponding values in the summary list box
                summaryListbox.Items.Add(transactNo + "      |  " + quantity + "  |  " + itemListbox.SelectedItem + " | " + typeListbox.SelectedItem + " | " + "€" + price );
                StreamWriter stockWtr = new StreamWriter(DccStockLocation);
                StoremyData[MealSizeIndex + 1][MealTypeIndex + 1] = (Int32.Parse(StoremyData[MealSizeIndex + 1][MealTypeIndex + 1]) - quantity).ToString();  // code to upadte stock in the csv file
                
                for (int i = 0; i < DCCstockRow; i++)
                {
                    string updates = "";
                    for (int j= 0; j < StoremyData[i].Length; j++)
                    {
                        updates += StoremyData[i][j] + ",";
                    }
                    stockWtr.WriteLine(updates);
                }
                stockWtr.Close();
            }            
        }

        /******************************** Logic used when Add to Order button is clicked **************************************/

        private void addOrderbutton_Click(object sender, EventArgs e)
        {
            summaryListbox.Visible   = false;
            priceLabel.Visible       = false;
            tableLayoutPanel.Visible = false;
            confirmButton.Enabled    = true;
            clearButton.Enabled      = true;

            int MealTypeIndex = itemListbox.SelectedIndex;
            int MealSizeIndex = typeListbox.SelectedIndex;

            if (MealTypeIndex != -1)
            {
                if (MealSizeIndex != -1)
                {
                    price = MealCost[MealSizeIndex, MealTypeIndex];
                }
            }
            PriceTextbox.Text = price.ToString("c", new CultureInfo("en-FR"));
            if (!string.IsNullOrEmpty(QtyTextbox.Text) && int.Parse(QtyTextbox.Text) > 0)
            {                              
                TrackStockBalance(); 
            }

            finalLabel.Text = fulltotalMealcost.ToString("c", new CultureInfo("en-FR"));
            finalLabel.Visible = false;
        }

        /******************************** Logic used when Confirm button is clicked **************************************/

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Making the summary listbox visible as well as the buttons
            summaryListbox.Visible   = true;
            priceLabel.Visible       = true;
            tableLayoutPanel.Visible = true;
            finalLabel.Visible       = true;
            submitButton.Enabled     = true;
        }

        /******************************** Logic used when Submit button is clicked **************************************/

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Just a confirmation to user saying the order has been processed
            MessageBox.Show("Your order has been successfully processed!", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            exitButton.Enabled = true;
        }

        /******************************** Logic used when Clear button is clicked **************************************/

        private void clearButton_Click(object sender, EventArgs e)
        {
            // To uncheck and clear the text boxes
            PriceTextbox.Text         = "";
            QtyTextbox.Text           = "";
            typeListbox.SelectedIndex = -1;
            itemListbox.SelectedIndex = -1;
            summaryListbox.Items.Clear();
            displaylabel.Text         = "";
            finalLabel.Text           = "";

            //logic to update stock back when the user has cancelled the order. Read the stock file from the saved path and to store its values to a list.
            string DccStockLocation = "DCC Stock.csv";
            StreamReader LineRead = new StreamReader(DccStockLocation);
            var ReadLine = new List<string[]>();
            int DCCstockRow = 0;
            while (!LineRead.EndOfStream)
            {
                string[] TempLine = LineRead.ReadLine().Split(',');
                ReadLine.Add(TempLine);
                DCCstockRow++;
            }
            LineRead.Close();
            var stockadd = ReadLine.ToArray();   //Stores data to an array.

            // To start writing the updated contents to the stock file
            foreach (var orditems in itemOrders)
            {
                for(int k=0; k<= itemOrders.LastIndexOf(orditems); k++)
                {
                    int MealTypeIndex     = Int32.Parse(itemOrders[k][1]);
                    int MealSizeIndex     = Int32.Parse(itemOrders[k][2]);
                    string updatemystock  = itemOrders[k][0];
                    stockadd[MealSizeIndex][MealTypeIndex] = updatemystock;
                    StreamWriter stockWtr = new StreamWriter(DccStockLocation);
                    for (int i = 0; i < DCCstockRow; i++)
                    {
                        string updates = "";
                        for (int j = 0; j < stockadd[i].Length; j++)
                        {
                            updates += stockadd[i][j] + ",";
                        }
                        stockWtr.WriteLine(updates);
                    }
                    stockWtr.Close();
                }
            }
        }

        /******************************** Logic used when Exit button is clicked **************************************/

        private void exitButton_Click(object sender, EventArgs e)
        {           
            DateTime currentDateTime = DateTime.Now;                                                     // To get the current instant date and time
            String OutputFilePath = "Transaction " + currentDateTime.ToString("dd-MM-yyyy") + ".txt";    // Highlighting the name of the output file and making sure its in dd-mm-yyyy format
            if(!File.Exists(OutputFilePath))                                       // Case when file name doesn't exist i.e. creating file for the first time                                           
            {
                FileInfo newfile = new FileInfo(OutputFilePath);
                newfile.Directory.Create();
                FileStream filestr = File.Create(OutputFilePath);
                filestr.Close();
                StreamWriter OutputFile = new StreamWriter(OutputFilePath);
                OutputFile.WriteLine("Transact No | Quantity| MealType | MealSize |  TotalPrice ");   // To make sure that we have headers at the top for each text file
                foreach (var item in summaryListbox.Items)
                {
                    OutputFile.WriteLine(item.ToString());                                                    // writing down the details from the list 
                }
                OutputFile.WriteLine(Environment.NewLine +"        Overall Price:      " + fulltotalMealcost.ToString("c", new CultureInfo("en-FR"))); // to get the overall cost at the end of each transaction
                OutputFile.WriteLine(Environment.NewLine + "******** END OF TRANSACTION AT " + currentDateTime +" *******"); // this will help the user realise the transaction done at particular instinct
                OutputFile.Close();
            }
            else
            {
                // Case when another transaction has happened on the same day, and hence it should be appended on the same file
                StreamWriter OutputFile = new StreamWriter(File.Open(OutputFilePath, FileMode.Append)); 
                foreach (var item in summaryListbox.Items)
                {
                    OutputFile.WriteLine(Environment.NewLine + item.ToString());
                }
                OutputFile.WriteLine(Environment.NewLine +"        Overall Price:      " + fulltotalMealcost.ToString("c", new CultureInfo("en-FR")));
                OutputFile.WriteLine(Environment.NewLine + "******** END OF TRANSACTION AT " + currentDateTime + " *******");
                OutputFile.Close();
            }
            
            //For exiting the application
            this.Close();
            Application.Exit();
        }
    }
}   