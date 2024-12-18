/* 
 * Program  pmsUI v4.0
 * Author   Joshua Gregory, Nov/Dec 2024
 * Course   Professor Dingler, SWE-3313
 *
 * NOTES:
 * Prototype 2 is designed to test menu functional requirements and UX quality requirements.
 * Exclusions: user authentication, database operations (querying, updating), payment processing
 * (with payment gateway API for debit/credit EFT), receipt printing.
 */

using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms.VisualStyles;
#nullable enable

namespace pmsUI
{
    /// <summary>
    /// Form1 class:
    /// Defines functionality for GUI elements.
    /// </summary>
    public partial class Form1 : Form
    {
        // INITIALIZE FORM
        public Form1()
        {
            InitializeComponent();
        }

        // INITIALIZE ORDER OBJECT
        public Order currOrder = new Order();  // instantiated here for data sharing

        // LOGOUT BUTTONS (TABS 1 - 6)
        private void btnP2_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                currOrder = new Order();        // reinitialize to clear fields
                tabControl1.SelectedIndex = 0;  // nav to Login tab idx
            }
        }
        private void btnP3_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                currOrder = new Order();        // reinitialize to clear fields
                tabControl1.SelectedIndex = 0;  // nav to Login tab idx
            }
        }
        private void btnP4_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                currOrder = new Order();        // reinitialize to clear fields
                tabControl1.SelectedIndex = 0;  // nav to login
            }
        }
        private void btnP5_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                currOrder = new Order();        // reinitialize to clear fields
                tabControl1.SelectedIndex = 0;  // nav to Login tab idx
            }
        }
        private void btnP6_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                currOrder = new Order();        // reinitialize to clear fields
                tabControl1.SelectedIndex = 0;  // nav to Login tab idx
            }
        }

        // HELP BUTTONS (TABS 1 - 6)
        private void btnP1_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prototype credentials:\nUsername: testUser\nPassword: Password1\n");
        }
        private void btnP2_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home help text will go here.");
        }
        private void btnP3_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select Item help text will go here.");
        }
        private void btnP4_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Pizza help text will go here.");
        }
        private void btnP5_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Beverage help text will go here.");
        }
        private void btnP6_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Current Order help text will go here.");
        }

        // CANCEL ORDER BUTTONS (TABS 3 - 6)
        private void btnP3_cancelHome_Click(object sender, EventArgs e)
        {
            // confirm user choice
            DialogResult result = MessageBox.Show("Do you want to start the order over?",
                "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                currOrder = new Order();        // reinitialize Order obj
                UpdateOrderDetails();           // update (clear) order details
                CalculateOrderTotals();         // update (clear) order totals
                tabControl1.SelectedIndex = 1;  // nav to Home tab idx
            }
        }
        private void btnP4_cancelHome_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to start the order over?",
                "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                currOrder = new Order();
                UpdateOrderDetails();
                CalculateOrderTotals();
                tabControl1.SelectedIndex = 1;
            }
        }
        private void btnP5_cancelHome_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to start the order over?",
                "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                currOrder = new Order();
                UpdateOrderDetails();
                CalculateOrderTotals();
                tabControl1.SelectedIndex = 1;
            }
        }
        private void btnP6_cancelHome_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to start the order over?",
                "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                currOrder = new Order();
                UpdateOrderDetails();
                CalculateOrderTotals();
                tabControl1.SelectedIndex = 1;
            }
        }

        /*
         * +------------+
         * | TAB: LOGIN |
         * +------------+
         */
        private void btnP1_login_Click(object sender, EventArgs e)
        {
            // demo authentication, production will use either Windows accounts or Employee DB table
            if (tboxP1_user.Text == "testUser" && tboxP1_pass.Text == "Password1")
            {
                tabControl1.SelectedIndex = 1;  // nav to Home tab idx
                tboxP1_user.Clear();            // clear fields
                tboxP1_pass.Clear();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Use the '?' help button for assistance.");
                tboxP1_user.Clear();  // clear fields
                tboxP1_pass.Clear();
            }
        }

        /*
         * +-----------+
         * | TAB: HOME |
         * +-----------+
         */
        private void btnP2_transactions_Click(object sender, EventArgs e)
        {
            // Production will nav to history tab & use Data.SqlClient in DbOps.showHistory()
            MessageBox.Show("Transaction history currently disabled.");
        }

        /// <summary>
        /// Form1.cs helper method to maintain Order state when navigating backward.
        /// </summary>
        private void btnP2_startCarryout_Click(object sender, EventArgs e)
        {
            currOrder.OrderType = "Carryout";  // set OrderType field
            CalculateOrderTotals();            // update order totals
            UpdateOrderDetails();              // keep order current
            tabControl1.SelectedIndex = 2;     // nav to Item Select tab idx
        }
        private void btnP2_startDelivery_Click(object sender, EventArgs e)
        {
            currOrder.OrderType = "Delivery";  // set OrderType field
            CalculateOrderTotals();            // update order totals
            UpdateOrderDetails();              // keep order current
            tabControl1.SelectedIndex = 2;     // nav to Item Select tab idx
        }


        /* 
         * +--------------------------------------+
         * | TAB: ITEM SELECT (PIZZA OR BEVERAGE) |
         * +--------------------------------------+
         */
        private void btnP3_editCustInfo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;  // nav to Home tab idx
        }
        private void btnP3_viewOrder_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;  // nav to View Order tab idx
        }
        private void btnP3_addPizza_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;  // nav to Add Pizza tab idx
        }
        private void btnP3_addBevg_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;  // nav to Add Beverage tab idx
        }

        /* 
         * +----------------+
         * | TAB: ADD PIZZA |
         * +----------------+
         */
        /// <summary>
        /// Form1.cs helper method to reseet all controls on Add Pizza tabpage.
        /// </summary>
        private void ResetPizzaControls()
        {
            // clear selections
            combo_pizzaSize.SelectedIndex = -1;
            combo_pizzaCrust.SelectedIndex = -1;
            combo_pizzaSauce.SelectedIndex = -1;
            combo_pizzaExChs.SelectedIndex = -1;
            combo_pepp.SelectedIndex = -1;
            combo_sausage.SelectedIndex = -1;
            combo_grlChkn.SelectedIndex = -1;
            combo_bacon.SelectedIndex = -1;
            combo_ham.SelectedIndex = -1;
            combo_mushroom.SelectedIndex = -1;
            combo_olive.SelectedIndex = -1;
            combo_tomato.SelectedIndex = -1;
            combo_banPepper.SelectedIndex = -1;
            combo_jalPepper.SelectedIndex = -1;
            combo_pineapple.SelectedIndex = -1;
            combo_anchovy.SelectedIndex = -1;
            textbox_special.Clear();
        }

        /// <summary>
        /// Form1.cs helper method to truncate special isntructions to 30 chars for display & DB.
        /// </summary>
        /// <param name="input">Text from special instructions textBox.</param>
        /// <returns>Truncated input string.</returns>
        private string TruncSpclInstr(string input)
        {
            return input.Length > 30 ? input.Substring(0, 30) : input;  // return truncated argument
        }

        /// <summary>
        /// Form1.cs helper method to reset all controls on Add Pizza tabpage.
        /// Called after adding/canceling a Pizza.
        /// </summary>       
        private void btnP4_addPizza_Click(object sender, EventArgs e)
        {
            // GET PIZZA OBJ DATA           
            if (combo_pizzaSize.SelectedItem == null)
            {
                // validate required selections are non-null
                MessageBox.Show("Please select a valid pizza size.");
                return;
            }
            else if (combo_pizzaCrust.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid crust type.");
                return;
            }
            else if (combo_pizzaSauce.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid sauce type.");
                return;
            }
            else if (combo_pizzaExChs.SelectedItem == null)
            {
                MessageBox.Show("Please select if you want extra cheese (yes/no).");
                return;
            }
            else
            {
                // store non-null required selections to temp variables
                string size = combo_pizzaSize.Text;
                string crust = combo_pizzaCrust.Text;
                string sauce = combo_pizzaSauce.Text;
                string extraCheese = combo_pizzaExChs.Text;

                string special = TruncSpclInstr(textbox_special.Text);  // ensure text <= 30 chars 
                List<string> tempToppingList = new List<string>();      // store toppings in temp list
                int numToppings = 0;                                    // track number of toppings
                double price = 0;                                       // initialize at 0

                // add non-null toppings to temp list
                if (combo_pepp.SelectedItem != null)
                {
                    tempToppingList.Add(combo_pepp.Text);  // add topping to temp list
                    numToppings += 1;                      // increment counter
                }
                if (combo_sausage.SelectedItem != null)
                {
                    tempToppingList.Add(combo_sausage.Text);
                    numToppings += 1;
                }
                if (combo_grlChkn.SelectedItem != null)
                {
                    tempToppingList.Add(combo_grlChkn.Text);
                    numToppings += 1;
                }
                if (combo_bacon.SelectedItem != null)
                {
                    tempToppingList.Add(combo_bacon.Text);
                    numToppings += 1;
                }
                if (combo_ham.SelectedItem != null)
                {
                    tempToppingList.Add(combo_ham.Text);
                    numToppings += 1;
                }
                if (combo_mushroom.SelectedItem != null)
                {
                    tempToppingList.Add(combo_mushroom.Text);
                    numToppings += 1;
                }
                if (combo_tomato.SelectedItem != null)
                {
                    tempToppingList.Add(combo_tomato.Text);
                    numToppings += 1;
                }
                if (combo_olive.SelectedItem != null)
                {
                    tempToppingList.Add(combo_olive.Text);
                    numToppings += 1;
                }
                if (combo_banPepper.SelectedItem != null)
                {
                    tempToppingList.Add(combo_banPepper.Text);
                    numToppings += 1;
                }
                if (combo_jalPepper.SelectedItem != null)
                {
                    tempToppingList.Add(combo_jalPepper.Text);
                    numToppings += 1;
                }
                if (combo_pineapple.SelectedItem != null)
                {
                    tempToppingList.Add(combo_pineapple.Text);
                    numToppings += 1;
                }
                if (combo_anchovy.SelectedItem != null)
                {
                    tempToppingList.Add(combo_anchovy.Text);
                    numToppings += 1;
                }

                // derive price from selections
                if (extraCheese == "Yes")
                {
                    price += 1.99;  // add fee for extra cheese
                }
                if (size == "SM")
                {
                    price += 6.99;  // add price for pizza size
                }
                if (size == "MD")
                {
                    price += 9.99;
                }
                if (size == "LG")
                {
                    price += 12.99;
                }
                if (size == "XL")
                {
                    price += 15.99;
                }
                if (numToppings > 4)
                {
                    double toppingFee = ((numToppings - 4) * 0.99);  // add 0.99 per topping > 4
                    price += toppingFee;
                }

                // create Pizza obj
                Pizza pizza = new Pizza(size, crust, sauce, extraCheese, tempToppingList, special, price);
                currOrder.PizzaList.Add(pizza);  // add pizza obj to order
                UpdateOrderDetails();            // update checklistbox of order details
                CalculateOrderTotals();          // update listbox of order totals
                ResetPizzaControls();            // reset all pizza controls
                tabControl1.SelectedIndex = 5;   // nav to View Order tab idx
            }                      
        }

        private void btnP4_cancelPizza_Click(object sender, EventArgs e)
        {
            // cancel pizza selections
            ResetPizzaControls();           // reset pizza controls
            tabControl1.SelectedIndex = 2;  // nav to Item Select tab idx
        }

        /* 
         * +--------------------+
         * | TAB: ADD BEVERAGES |
         * +--------------------+
         */
        // temp list to store objs before being added to Order.BeverageList
        List<Beverage> tempBevgList = new List<Beverage>();

        private void btnP5_addRootBeer_Click(object sender, EventArgs e)
        {
            // ADD ROOT BEER
            if (string.IsNullOrEmpty(combo_rootBeer.Text) || qty_rootBeer.Value <= 0)
            {
                // validate non-null selections
                MessageBox.Show("Please choose the beverage's size and quantity to add to order.");
            }
            else
            {
                // set values for rootBeer obj fields
                string bevgFlavor = "Root Beer";
                string bevgSize = combo_rootBeer.Text;
                int bevgQty = (int)qty_rootBeer.Value;
                double bevgPrice = 0;

                // modify bevgPrice for size and qty
                if (bevgSize == "12oz")
                {
                    bevgPrice = Math.Round(1.49 * bevgQty, 2);
                }
                else if (bevgSize == "20oz")
                {
                    bevgPrice = Math.Round(2.49 * bevgQty, 2);
                }
                else if (bevgSize == "2Litre")
                {
                    bevgPrice = Math.Round(3.49 * bevgQty, 2);
                }

                // instantiate beverage, add to tempBevgList
                Beverage rootBeer = new Beverage(bevgFlavor, bevgSize, bevgQty, bevgPrice);
                tempBevgList.Add(rootBeer);  // add to temp list

                combo_rootBeer.SelectedIndex = -1;          // reset size combobox
                qty_rootBeer.Value = qty_rootBeer.Minimum;  // reset qty selector
            }
        }

        private void btnP5_addCola_Click(object sender, EventArgs e)
        {
            // ADD COLA
            if (string.IsNullOrEmpty(combo_cola.Text) || qty_cola.Value <= 0)
            {
                // validate non-null selections
                MessageBox.Show("Please choose the beverage's size and quantity to add to order.");
            }
            else
            {
                // set non-null values for cola obj fields
                string bevgFlavor = "Cola";
                string bevgSize = combo_cola.Text;
                int bevgQty = (int)qty_cola.Value;
                double bevgPrice = 0;

                // modify bevgPrice for size and qty
                if (bevgSize == "12oz")
                {
                    bevgPrice = Math.Round(1.49 * bevgQty, 2);
                }
                else if (bevgSize == "20oz")
                {
                    bevgPrice = Math.Round(2.49 * bevgQty, 2);
                }
                else if (bevgSize == "2Litre")
                {
                    bevgPrice = Math.Round(3.49 * bevgQty, 2);
                }

                // instantiate beverage, add to tempBevgList
                Beverage cola = new Beverage(bevgFlavor, bevgSize, bevgQty, bevgPrice);
                tempBevgList.Add(cola);  // add to temp list

                combo_cola.SelectedIndex = -1;      // reset size combobox
                qty_cola.Value = qty_cola.Minimum;  // reset qty selector
            }
        }

        private void btnP5_addDietCola_Click(object sender, EventArgs e)
        {
            // ADD DIET COLA
            if (string.IsNullOrEmpty(combo_dietCola.Text) || qty_dietCola.Value <= 0)
            {
                // validate non-null selections
                MessageBox.Show("Please choose the beverage's size and quantity to add to order.");
            }
            else
            {
                // set non-null values for diet cola obj fields
                string bevgFlavor = "Diet Cola";
                string bevgSize = combo_dietCola.Text;
                int bevgQty = (int)qty_dietCola.Value;
                double bevgPrice = 0;

                // modify bevgPrice for size and qty
                if (bevgSize == "12oz")
                {
                    bevgPrice = Math.Round(1.49 * bevgQty, 2);
                }
                else if (bevgSize == "20oz")
                {
                    bevgPrice = Math.Round(2.49 * bevgQty, 2);
                }
                else if (bevgSize == "2Litre")
                {
                    bevgPrice = Math.Round(3.49 * bevgQty, 2);
                }

                // instantiate beverage, add to tempBevgList
                Beverage dietCola = new Beverage(bevgFlavor, bevgSize, bevgQty, bevgPrice);
                tempBevgList.Add(dietCola);  // add to temp list

                combo_dietCola.SelectedIndex = -1;          // reset size combobox
                qty_dietCola.Value = qty_dietCola.Minimum;  // reset qty selector
            }
        }

        private void btnP5_addLemonade_Click(object sender, EventArgs e)
        {
            // ADD LEMONADE
            if (string.IsNullOrEmpty(combo_lemonade.Text) || qty_lemonade.Value <= 0)
            {
                // validate non-null selections
                MessageBox.Show("Please choose the beverage's size and quantity to add to order.");
            }
            else
            {
                // set non-null values for lemonade obj fields
                string bevgFlavor = "Lemonade";
                string bevgSize = combo_lemonade.Text;
                int bevgQty = (int)qty_lemonade.Value;
                double bevgPrice = 0;

                // modify bevgPrice for size and qty
                if (bevgSize == "12oz")
                {
                    bevgPrice = Math.Round(1.49 * bevgQty, 2);
                }
                else if (bevgSize == "20oz")
                {
                    bevgPrice = Math.Round(2.49 * bevgQty, 2);
                }
                else if (bevgSize == "2Litre")
                {
                    bevgPrice = Math.Round(3.49 * bevgQty, 2);
                }

                // instantiate beverage, add to tempBevgList
                Beverage lemonade = new Beverage(bevgFlavor, bevgSize, bevgQty, bevgPrice);
                tempBevgList.Add(lemonade);  // add to temp list

                combo_lemonade.SelectedIndex = -1;          // reset size combobox
                qty_lemonade.Value = qty_lemonade.Minimum;  // reset qty selector
            }
        }

        private void btnP5_addSwtTea_Click(object sender, EventArgs e)
        {
            // ADD SWEET TEA
            if (string.IsNullOrEmpty(combo_swtTea.Text) || qty_swtTea.Value <= 0)
            {
                // validate non-null selections
                MessageBox.Show("Please choose the beverage's size and quantity to add to order.");
            }
            else
            {
                // set non-null values for sweet tea obj fields
                string bevgFlavor = "Sweet Tea";
                string bevgSize = combo_swtTea.Text;
                int bevgQty = (int)qty_swtTea.Value;
                double bevgPrice = 0;

                // modify bevgPrice for size and qty
                if (bevgSize == "12oz")
                {
                    bevgPrice = Math.Round(1.49 * bevgQty, 2);
                }
                else if (bevgSize == "20oz")
                {
                    bevgPrice = Math.Round(2.49 * bevgQty, 2);
                }
                else if (bevgSize == "2Litre")
                {
                    bevgPrice = Math.Round(3.49 * bevgQty, 2);
                }

                // instantiate beverage, add to tempBevgList
                Beverage swtTea = new Beverage(bevgFlavor, bevgSize, bevgQty, bevgPrice);
                tempBevgList.Add(swtTea);  // add to temp list

                combo_swtTea.SelectedIndex = -1;      // reset size control
                qty_swtTea.Value = qty_swtTea.Minimum;  // reset qty selector
            }
        }

        /// <summary>
        /// Form1.cs helper method to reset all controls on Add Beverage tabpage.
        /// </summary>
        private void ResetBeverageControls()
        {
            // reset to original values
            combo_rootBeer.SelectedIndex = -1;
            combo_cola.SelectedIndex = -1;
            combo_dietCola.SelectedIndex = -1;
            combo_lemonade.SelectedIndex = -1;
            combo_swtTea.SelectedIndex = -1;
            qty_rootBeer.Value = qty_rootBeer.Minimum;
            qty_cola.Value = qty_cola.Minimum;
            qty_dietCola.Value = qty_dietCola.Minimum;
            qty_lemonade.Value = qty_lemonade.Minimum;
            qty_swtTea.Value = qty_swtTea.Minimum;
        }

        private void btnP5_addToOrder_Click(object sender, EventArgs e)
        {
            // iterate tempBevgList to add each obj to Order.BeverageList
            foreach (var beverage in tempBevgList)
            {
                currOrder.AddBeverage(beverage);  // same name != same instance
            }

            tempBevgList.Clear();                 // clear selections from temp list
            UpdateOrderDetails();                 // update checklistbox of order details
            CalculateOrderTotals();               // update listbox of order totals
            ResetBeverageControls();              // reset all pizza controls
            tabControl1.SelectedIndex = 5;        // nav to View Order tab idx
        }

        private void btnP5_cancelBevg_Click(object sender, EventArgs e)
        {
            // cancel beverage selections
            ResetBeverageControls();        // clear all Beverage controls
            tabControl1.SelectedIndex = 2;  // nav to Item Select tab idx
        }

        /* 
         * +----------------------+
         * | TAB: VIEW ORDER CART |
         * +----------------------+
         */
        public string payMethod = "";

        private void btnP6_addItems_Click(object sender, EventArgs e)
        {
            // go back and add more items to order
            tabControl1.SelectedIndex = 2;  // nav to Item Select tab idx
        }

        /// <summary>
        /// Form1.cs helper method that updates checkListBox displaying details of ordered items.
        /// Called after a Pizza or Beverage object is added or removed to/from Order.
        /// </summary>
        private void UpdateOrderDetails()
        {
            // call after adding Pizza or Beverage obj to Order.PizzaList or Order.BeverageList
            chkListBox_orderDetails.Items.Clear();

            // add new object to checklistbox using display method
            foreach (var pizza in currOrder.PizzaList)
            {
                chkListBox_orderDetails.Items.Add(pizza.GetPizzaDetails());
            }
            foreach (var beverage in currOrder.BeverageList)
            {
                chkListBox_orderDetails.Items.Add(beverage.GetBeverageDetails());
            }
        }

        /// <summary>
        /// Form1.cs helper method that calls Order.GetOrderTotals() to calculate price details.
        /// </summary>
        private void CalculateOrderTotals()
        {
            currOrder.GetOrderTotals();  // Order class method

            // update listbox with values
            listBoxTotals.Items.Clear();
            listBoxTotals.Items.Add($"Subtotal: {currOrder.Subtotal:C}");
            listBoxTotals.Items.Add($"Tax: {currOrder.Tax:C}");
            listBoxTotals.Items.Add($"Fee: {currOrder.Fee:C}");
            listBoxTotals.Items.Add($"Order Total: {currOrder.Total:C}");
        }

        private void btnP6_removeIte_Click(object sender, EventArgs e)
        {
            // remove items from currOrder.PizzaList and/or currOrder.BeverageList
            List<int> indexesToRemove = new List<int>();

            foreach (int index in chkListBox_orderDetails.CheckedIndices)
            {
                indexesToRemove.Add(index);
            }

            indexesToRemove.Sort();     // sort then reverse indices to
            indexesToRemove.Reverse();  // prevent index shifting errors

            foreach (int index in indexesToRemove)
            {
                if (index < currOrder.PizzaList.Count)
                {
                    currOrder.PizzaList.RemoveAt(index);
                }
                else
                {
                    currOrder.BeverageList.RemoveAt(index - currOrder.PizzaList.Count);
                }
            }
            UpdateOrderDetails();      // update ordered items
            CalculateOrderTotals();    // update order totals
        }

        /// <summary>
        /// Form1.cs helper method that demos receipt functionality for prototype.
        /// </summary>
        /// <returns>string receipt</returns>
        private string FormatReceipt()
        {
            // get random but typical carryout & delivery times
            Random rando = new Random();
            int carryoutTime = rando.Next(15, 46);  // random value over [15,45]
            int deliveryTime = rando.Next(30, 61);  // random value over [30,60]
            DateTime currTime = DateTime.Now;       // current EST time
            DateTime carryoutReady = currTime.AddMinutes(carryoutTime);  // add times
            DateTime deliveryReady = currTime.AddMinutes(deliveryTime);  // add times

            // format receipt string
            StringBuilder receipt = new StringBuilder();

            receipt.AppendLine($"Receipt");
            receipt.AppendLine("--------");
            receipt.Append($"Order ID: {currOrder.OrderID}\n");

            receipt.AppendLine("\nPizza(s):");    
            foreach (var pizza in currOrder.PizzaList)
            {
                receipt.AppendLine(pizza.GetPizzaDetails());       // display pizzas
            }

            receipt.AppendLine("\nBeverage(s):");
            foreach (var beverage in currOrder.BeverageList)
            {
                receipt.AppendLine(beverage.GetBeverageDetails());  // display beverages
            }

            // add Order details to string
            receipt.AppendLine($"\nOrder Type: {currOrder.OrderType}");
            receipt.AppendLine($"Total: {currOrder.Total:C}");
            receipt.AppendLine($"Payment Method: {currOrder.PayMethod}\n");

            if (currOrder.PayMethod == "Card")
            {
                receipt.AppendLine($"Signature: ____________________\n");       // signature line
            }

            if (currOrder.OrderType == "Carryout")
            {
                receipt.Append($"Estimated pickup time: {carryoutReady}.");   // carryout time
            }
            else
            {
                receipt.Append($"Estimated delivery time: {deliveryReady}.");  // delivery time
            }

            return receipt.ToString();  // to show in MessageBox
        }

        // submit order & print receipt (MessageBox for prototype)
        private void btnP6_submitOrder_Click(object sender, EventArgs e)
        {
            // validate a payment method has been selected
            if (combo_payType.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid payment method.");
            }
            else
            {
                currOrder.PayMethod = combo_payType.Text;  // store non-null payment method
                MessageBox.Show(FormatReceipt());          // format & display prototype demo receipt

                // prepare system for next order
                chkListBox_orderDetails.Items.Clear();     // rest item details checklistbox
                listBoxTotals.Items.Clear();               // reset order price details listbox
                combo_payType.SelectedIndex = -1;         // reset payment method combobox

                currOrder = new Order();                   // reinstantiate Order obj
                tabControl1.SelectedIndex = 1;             // nav to Home tab idx

                // Prodcution will nav to Payment (or PaymentGateway for cards) then ReceiptPrinter.
            }    
        }
    }

    /*
     * +-------------------------+
     * | START CLASS DEFINITIONS |
     * +-------------------------+
     */

    /// <summary>
    /// PIZZA CLASS
    /// GUI buttons direct instantiation of Pizza objects that are added to Order.PizzaList on submit.
    /// Price field is set in GUI based on user selections.
    /// </summary>
    public class Pizza
    {
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public string ExtraCheese { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();
        public string SpecialInstructions { get; set; }
        public double Price { get; set; }  // set in GUI logic

        public Pizza(string size, string crust, string sauce, string extraChs, List<string> toppings,
            string specialInstr, double price)
        {
            this.Size = size;
            this.Crust = crust;
            this.Sauce = sauce;
            this.ExtraCheese = extraChs;
            this.Toppings = toppings;
            this.SpecialInstructions = specialInstr;
            this.Price = price;
        }

        public string GetPizzaDetails()
        {
            // ensure no nulls, join list items into string, display option for no toppings
            string toppingsList = Toppings != null && 
                Toppings.Count > 0 ? string.Join(", ", Toppings) : "plain cheese";
            
            // resulting output string
            return $"{Price:C} - {Size} {Crust} crust pizza with {Sauce} sauce / " +
                $"Extra cheese: {ExtraCheese} / Toppings: {toppingsList} / " +
                $"Special instructions: {SpecialInstructions}.";
        }
    }

    /// <summary>
    /// Beverage class:
    /// GUI buttons direct instantiation of Beverage objects that are added to temp list.
    /// The temp list is traversed and objects are added to Order.BeverageList.
    /// </summary>
    public class Beverage
    {
        public string Flavor { get; set; }
        public string Size { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }   // set in GUI logic

        public Beverage(string flavor, string size, int qty, double price)
        {
            this.Flavor = flavor;
            this.Size = size;
            this.Qty = qty;
            this.Price = price;
        }

        public string GetBeverageDetails()
        {
            return $"{Price:C} - {Size} {Flavor} x {Qty}";
        }
    }

    /// <summary>
    /// Order class:
    /// Order object with unique ID is instantiated at top of form to share data between tabpages.
    /// Pizza and Beverage objects are added to Order.PizzaList or BeverageList on instantiation.
    /// When the order is submitted, object is reinitialized (with a new ID) for next order.
    /// </summary>
    public class Order
    {
        public List<Pizza> PizzaList { get; set; }
        public List<Beverage> BeverageList { get; set; }
        public string OrderID { get; private set; }

        public string OrderType { get; set; }
        public string PayMethod { get; set; }
        public double Subtotal { get; private set; }
        public double Tax { get; private set; }
        public double Fee { get; private set; }
        public double Total { get; private set; }

        private static int orderCounter = 0;  // for use in orderID

        public Order()
        {
            PizzaList = new List<Pizza>();
            BeverageList = new List<Beverage>();
            OrderID = GenerateOrderID();

            OrderType = "Carryout"; // default
            PayMethod = "Cash";     // default
            Subtotal = 0;
            Tax = 0;
            Fee = 0;
            Total = 0;
        }

        // Generate a unique but readable OrderID
        private string GenerateOrderID()
        {
            // combine incremented counter with timestamp
            return $"{++orderCounter}.{DateTime.Now:yyyyMMddHHmmss}";
        }

        // Add items to list & recalculate prices
        public void AddPizza(Pizza pizza)
        {
            PizzaList.Add(pizza);
            GetOrderTotals();
        }
        public void AddBeverage(Beverage beverage)
        {
            BeverageList.Add(beverage);
            GetOrderTotals();
        }
        // Remove items & recalculate prices (determine which object type is being removed first)
        public void RemovePizza(Pizza pizza)
        {
            PizzaList.Remove(pizza);
            GetOrderTotals();
        }
        public void RemoveBeverage(Beverage beverage)
        {
            BeverageList.Remove(beverage);
            GetOrderTotals();
        }

        // Method to calculate totals dynamically
        public void GetOrderTotals()
        {
            // sum Price fields in each list
            Subtotal = PizzaList.Sum(p => p.Price) + BeverageList.Sum(b => b.Price);
            Tax = Subtotal * 0.1;
            Fee = OrderType == "Delivery" ? 3.99 : 0;
            Total = Subtotal + Tax + Fee;
        }

        // total number of items in order:
        public int GetNumItems()
        {
            int num = 0;
            num = PizzaList.Count + BeverageList.Count;
            return num;
        }

        public List<string> DisplayOrder()
        {
            List<string> details = new List<string>();

            foreach (var pizza in PizzaList)
            {
                details.Add(pizza.GetPizzaDetails());
            }

            foreach (var beverage in BeverageList)
            {
                details.Add(beverage.GetBeverageDetails());
            }

            return details;
        }
    }
}
