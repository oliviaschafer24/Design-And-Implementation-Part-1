using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Design_and_Implementation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Database farmDB;
            farmDB = Database.getInstance();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        bool canBeMoved = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (canBeMoved)
            {
                canBeMoved = false;
                int initX = pictureBox7.Location.X;
                int initY = pictureBox7.Location.Y;
                for (int i = 0; i < 101; i++)
                {
                    pictureBox7.SetBounds((622 - initX) * i / 100 + initX, (513 - initY) * i / 100 + initY, 66, 42);
                }
                canBeMoved = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (canBeMoved)
            {
                canBeMoved = false;
                int initX = pictureBox7.Location.X;
                int initY = pictureBox7.Location.Y;
                for (int i = 0; i < 101; i++)
                {
                    pictureBox7.SetBounds((924 - initX) * i / 100 + initX, (574 - initY) * i / 100 + initY, 66, 42);
                }
                canBeMoved = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (canBeMoved)
            {
                canBeMoved = false;
                int initX = pictureBox7.Location.X;
                int initY = pictureBox7.Location.Y;
                for (int i = 0; i < 101; i++)
                {
                    pictureBox7.SetBounds((651 - initX) * i / 100 + initX, (130 - initY) * i / 100 + initY, 66, 42);
                }
                canBeMoved = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (canBeMoved)
            {
                canBeMoved = false;
                int initX = pictureBox7.Location.X;
                int initY = pictureBox7.Location.Y;
                if (initX == 651)
                {
                    for (int i = 0; i < 101; i++)
                    {
                        pictureBox7.SetBounds((622 - initX) * i / 100 + initX, (513 - initY) * i / 100 + initY, 66, 42);
                    }
                    initX = pictureBox7.Location.X;
                    initY = pictureBox7.Location.Y;
                    for (int i = 0; i < 101; i++)
                    {
                        pictureBox7.SetBounds((924 - initX) * i / 100 + initX, (574 - initY) * i / 100 + initY, 66, 42);
                    }
                    initX = pictureBox7.Location.X;
                    initY = pictureBox7.Location.Y;
                    for (int i = 0; i < 101; i++)
                    {
                        pictureBox7.SetBounds((651 - initX) * i / 100 + initX, (130 - initY) * i / 100 + initY, 66, 42);
                    }
                }
                else if (initX == 924)
                {
                    for (int i = 0; i < 101; i++)
                    {
                        pictureBox7.SetBounds((622 - initX) * i / 100 + initX, (513 - initY) * i / 100 + initY, 66, 42);
                    }
                    initX = pictureBox7.Location.X;
                    initY = pictureBox7.Location.Y;
                    for (int i = 0; i < 101; i++)
                    {
                        pictureBox7.SetBounds((651 - initX) * i / 100 + initX, (130 - initY) * i / 100 + initY, 66, 42);
                    }
                }
                else if (initX == 622)
                {
                    for (int i = 0; i < 101; i++)
                    {
                        pictureBox7.SetBounds((924 - initX) * i / 100 + initX, (574 - initY) * i / 100 + initY, 66, 42);
                    }
                    initX = pictureBox7.Location.X;
                    initY = pictureBox7.Location.Y;
                    for (int i = 0; i < 101; i++)
                    {
                        pictureBox7.SetBounds((651 - initX) * i / 100 + initX, (130 - initY) * i / 100 + initY, 66, 42);
                    }
                }
                canBeMoved = true;
            }
        }

        public class Database
        {
            private static Database dbObject;
            int[] barnData;
            int[] cropsData;
            private Database()
            {
                int[] barnData = {30, 30, 100, 100, 30000};
                int[] cropsData = { 30, 150, 250, 250 ,50000};
            }
            public static Database getInstance()
            {
                if (dbObject == null)
                    dbObject = new Database();
                return dbObject;
            }
            public void printData()
            {
                Console.WriteLine("Data for Barn:" + barnData);
                Console.WriteLine("Data for Crops:" + cropsData);
            }
        }

        interface farmItem
        {
            void showItemDetails();
        }

        class foodItem : farmItem
        {
            private String name;
            private int cost;
        public foodItem(String name, int cost)
            {
                this.name = name;
                this.cost = cost;
        }
            public void showItemDetails()
            {
                Console.WriteLine(name + " " + cost);
            }
        }

        class equipmentItem : farmItem
        {
            private String name;
            private int cost;
        public equipmentItem(String name, int cost)
            {
                this.name = name;
                this.cost = cost;
        }
            public void showItemDetails()
            {
                Console.WriteLine(name + " " + cost);
            }
        }

        farmItem[] push(farmItem[] l, farmItem s, int len)
        {
            farmItem[] final = new farmItem[len + 1];
            for(int i = 0; i < len; i++)
            {
                final[i] = l[i];
            }
            final[len - 1] = s;
            return final;
        }
        farmItem[] splice(farmItem[] l, int s, int len)
        {
            farmItem[] final = new farmItem[len - 1];
            for (int i = 0; i < s; i++)
            {
                final[i] = l[i];
            }
            for (int i = s+1; i < len; i++)
            {
                final[i-1] = l[i];
            }
            return final;
        }
        public class itemDirectory : farmItem
        {
            farmItem[] itemList;
            int lenItems = 0;
            public void showItemDetails()
            {
                foreach (farmItem item in itemList)
                {
                    item.showItemDetails();
                }
            }
            void addItem(farmItem item)
            {
                //itemList = push(itemList,item,lenItems); unable to implement
                lenItems++;
            }
            void removeItem(int s)
            {
                //itemList = splice(itemList, s, lenItems); unable to implement
                lenItems--;
            }
        }
    }
}
