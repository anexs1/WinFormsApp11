using System.Windows.Forms;

namespace WinFormsApp11
{

    public partial class Form1 : Form
    {
        private int[] numbers;  // Array to store the numbers (use int for numbers)

        public Form1()
        {
            InitializeComponent();
            numbers = null;  // Initialize array to null initially
            btnDelete.Enabled = true;  // Initially disable the "Delete" button
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            try
            {
                string[] elements = txtNameInput.Text.Split(',');
                numbers = Array.ConvertAll(elements, int.Parse);  // Convert to int array

                // Sort the numbers array in ascending order
                Array.Sort(numbers);

                // Clear existing items before adding new ones (optional)
                lstArray.Items.Clear();

                // Add each element from the sorted array to the ListBox
                foreach (int element in numbers)
                {
                    lstArray.Items.Add(element.ToString());  // Convert to string for display
                }

                lblStatus.Text = "Array created and sorted successfully.";
            }
            catch (FormatException ex)
            {
                lblStatus.Text = $"Invalid input format: {ex.Message}. Please enter comma-separated integers.";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (numbers == null)
            {
                lblStatus.Text = "Please create an array first.";
                return;
            }

            int updateIndex;
            int updateValue;
            try
            {
                updateIndex = int.Parse(txtIndex.Text);
                updateValue = int.Parse(txtValue.Text);
            }
            catch (FormatException)
            {
                lblStatus.Text = "Invalid index or value. Please enter integers.";
                return;
            }

            if (updateIndex < 0 || updateIndex >= numbers.Length)
            {
                lblStatus.Text = "Index out of bounds. Please enter a valid index within the array size.";
                return;
            }

            numbers[updateIndex] = updateValue;  // Update the element at the valid index

            // Update the ListBox to reflect the change (optional)
            lstArray.Items[updateIndex] = updateValue.ToString();  // Update specific item in ListBox

            // Resort the array after update
            Array.Sort(numbers);

            // Update the ListBox to reflect the sorted array
            lstArray.Items.Clear();
            foreach (int element in numbers)
            {
                lstArray.Items.Add(element.ToString());
            }

            lblStatus.Text = "Element updated and array re-sorted successfully.";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (numbers == null)
            {
                lblStatus.Text = "No array to delete.";
                return;
            }

            if (lstArray.SelectedIndex < 0)
            {
                lblStatus.Text = "Please select an item from the list box to delete.";
                return;
            }

            int deleteIndex = lstArray.SelectedIndex;

            // Check if deleting the last element (simplification)
            if (deleteIndex == numbers.Length - 1)
            {
                numbers = numbers.Take(numbers.Length - 1).ToArray();  // Use LINQ for simpler resizing
            }
            else
            {
                // Create a new array with one less element
                int[] newArray = new int[numbers.Length - 1];

                // Copy elements before the deleted index
                Array.Copy(numbers, 0, newArray, 0, deleteIndex);

                // Copy elements after the deleted index (excluding the deleted element)
                Array.Copy(numbers, deleteIndex + 1, newArray, deleteIndex, numbers.Length - deleteIndex - 1);

                numbers = newArray;  // Assign the new array reference
            }

            // Update the ListBox (important!)
            lstArray.Items.RemoveAt(deleteIndex);

            lblStatus.Text = "Element deleted successfully.";
        }

        private void lstArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = lstArray.SelectedIndex >= 0;  // Enable button only when an item is selected
        }
    }
}
