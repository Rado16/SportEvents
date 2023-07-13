using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportEvents
{
    public partial class Form1 : Form
    {
        List<SportEvent> sportEvents = new List<SportEvent>();
        Dictionary<string, SportEvent> sportEventsDictionary = new Dictionary<string, SportEvent>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] input = textBox1.Text.Split(' ').ToArray();

            int eventID = int.Parse(input[0]);
            string name = input[1];
            string location = input[2];
            string date = input[3];
            int ticketsAvailable = int.Parse(input[4]);
            double price = double.Parse(input[5]);

            SportEvent newSportEvent = new SportEvent(eventID, name, location, date, ticketsAvailable, price);
            sportEvents.Add(newSportEvent);
            sportEventsDictionary.Add(newSportEvent.Name, newSportEvent);
            textBox1.Clear();

            listBox1.Items.Clear();
            for (int i = 0; i < sportEvents.Count; i++)
            {
                listBox1.Items.Add(sportEvents[i].Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string eventName = (string)listBox1.SelectedItem;
            SportEvent selectedEvent = sportEventsDictionary[eventName];
            
            int ticketsCount = int.Parse(textBox2.Text);

            if (ticketsCount <= selectedEvent.TicketsAvailable)
            {
                double ticketsPrice = ticketsCount * selectedEvent.Price;
                textBox3.Text = ticketsPrice.ToString();
                selectedEvent.TicketsAvailable -= ticketsCount;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string eventName = textBox4.Text;
            SportEvent selectedEvent = sportEventsDictionary[eventName];
            textBox6.Text = selectedEvent.TicketsAvailable.ToString();
            textBox5.Text = selectedEvent.Price.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sportEvents.Count; i++)
            {
                listBox2.Items.Add($"{sportEvents[i].EventID} {sportEvents[i].Name}  {sportEvents[i].Location}  {sportEvents[i].Date}  {sportEvents[i].TicketsAvailable} {sportEvents[i].Price}");
            }
        }
    }
}
//2764 Football dt gl 7 1.6
//3247 Basketball eg vt 5 3.7