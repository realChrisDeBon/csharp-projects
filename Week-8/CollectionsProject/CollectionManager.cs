using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    public static class CollectionManager
    {
        private static List<int> _collection = new List<int>();
        public static List<int> collection
        {            
            get { return _collection; }
            set { _collection = value; }
        }

        public static void AddToCollection(int value)
        {
            if(collection.Count > 16)
            {
                MessageBox.Show("The collection is full. Please clear the collection before adding more values.", "Collection Full Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.frmCollections.txt_user_input.Clear();
                return;
            }

            if(value < -1217 || value > 1217)
            {
                MessageBox.Show("The value must be between -1217 and 1217.", "Value Out of Range Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.frmCollections.txt_user_input.Clear();
                return;
            }

            collection.Add(value);

            // Clear existing controls if needed
            Program.frmCollections.contentsDisplay.Controls.Clear();
            Program.frmCollections.statisticsDisplay.Controls.Clear();
        }

        public static void ClearCollection()
        {
            collection.Clear();
        }

    }

    public static class CollectionDisplayAdapter
    {
        public static void PopulateContentsDisplay()
        {
            // Clear existing controls if needed
            Program.frmCollections.contentsDisplay.Controls.Clear();

            // Add a label for each value in the collection
            foreach (int value in CollectionManager.collection)
            {
                Label label = new Label();
                label.Text = value.ToString();
                label.AutoSize = true;
                Program.frmCollections.contentsDisplay.Controls.Add(label);
            }

            CollectionManager.ClearCollection();
            Program.frmCollections.txt_user_input.Clear();
            StatisticsDisplayAdapter.WipeStatisticsDisplay();
        }

        public static void WipeContentsDisplay()
        {
            Program.frmCollections.contentsDisplay.Controls.Clear();
        }
    }

    public static class StatisticsDisplayAdapter
    {

        public static void PopulateStatisticsDisplay()
        {
            // Clear existing controls if needed
            Program.frmCollections.statisticsDisplay.Controls.Clear();

            if (CollectionManager.collection.Count == 0)
            {
                Label noDataLabel = new Label();
                noDataLabel.Text = "No data available.";
                noDataLabel.AutoSize = true;
                Program.frmCollections.statisticsDisplay.Controls.Add(noDataLabel);
                return;
            }

            // Initialize variables for statistics
            int count = 0;
            int highest = int.MinValue;
            int lowest = int.MaxValue;
            double sum = 0;

            // Walk the collection to calculate statistics
            foreach (int value in CollectionManager.collection)
            {
                count++;
                sum += value;
                if (value > highest)
                {
                    highest = value;
                }
                if (value < lowest)
                {
                    lowest = value;
                }
            }

            // Calculate average
            double average = sum / count;

            // Add labels for each statistic
            Label countLabel = new Label();
            countLabel.Text = $"Number of Numbers: {count}";
            countLabel.AutoSize = true;
            Program.frmCollections.statisticsDisplay.Controls.Add(countLabel);

            Label highestLabel = new Label();
            highestLabel.Text = $"High Number: {highest}";
            highestLabel.AutoSize = true;
            Program.frmCollections.statisticsDisplay.Controls.Add(highestLabel);

            Label lowestLabel = new Label();
            lowestLabel.Text = $"Low Number: {lowest}";
            lowestLabel.AutoSize = true;
            Program.frmCollections.statisticsDisplay.Controls.Add(lowestLabel);

            Label averageLabel = new Label();
            averageLabel.Text = $"Average: {average:F4}";
            averageLabel.AutoSize = true;
            Program.frmCollections.statisticsDisplay.Controls.Add(averageLabel);
        }

        public static void WipeStatisticsDisplay()
        {
            Program.frmCollections.statisticsDisplay.Controls.Clear();

            // inform user collection has been cleared
            Label infoLabel = new Label();
            infoLabel.Text = $"The collection has been cleared.";
            infoLabel.AutoSize = true;
            Program.frmCollections.statisticsDisplay.Controls.Add(infoLabel);

        }

    }
}