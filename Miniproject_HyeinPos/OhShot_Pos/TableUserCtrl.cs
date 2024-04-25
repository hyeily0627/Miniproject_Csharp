using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhShot_Pos
{
    public partial class TableUserCtrl : UserControl
    {
        public string tableNumber = string.Empty;
        ListSet ls = new ListSet();

        public TableUserCtrl()
        {
            InitializeComponent();
        }

        public void SetTableNum(string tableNum)
        {
            this.tableNumber = tableNum;
        }

        public void SetTableNumberLabel(string num)
        {
            this.TableNumbers.Text = tableNumber;
            tableNumber = num;
        }

        public void SetListBox()
        {
            menuListBox.Items.Clear();

            for (int i = 0; i < FoodTotalList.list.Count; i++)
            {
                menuListBox.Items.Add(FoodTotalList.list[i].Name + " * " + FoodTotalList.list[i].cnt);
            }
            menuListBox.SelectionMode = SelectionMode.None;
        }

        private void Clicked(object sender, EventArgs e)
        {
            Order order = new Order(tableNumber);
            order.OnOrderComplete += Order_OnOrderComplete;
            order.setListBox += Order_setListBox;
            order.Show();
        }

        private void Order_setListBox()
        {
            SetListBox();
        }

        private void Order_OnOrderComplete(object sender, EventArgs e)
        {
            ls.SetList(tableNumber);
            SetListBox();
        }
    }
}