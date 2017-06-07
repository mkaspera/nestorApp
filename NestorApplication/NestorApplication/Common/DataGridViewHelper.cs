using System;
using System.Windows.Forms;

namespace NestorApplication.Common
{
    public static class DataGridViewHelper
    {
        public static void SetGridProperties(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (grid.RowCount > 0)
            {
                grid.Rows[0].Selected = true;
            }
        }

        public static void SelectLastCellToEdit(DataGridView grid)
        {
            grid.Refresh();
            grid.Rows[grid.Rows.Count - 1].Selected = true;

            DataGridViewCell cell = grid.Rows[grid.Rows.Count - 1].Cells[0];
            grid.CurrentCell = cell;
            grid.BeginEdit(true);
        }

        public static void DeleteRow(DataGridView grid)
        {
            if (grid.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno usunąć zaznaczony rekord ?", "Usuwanie danych", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    grid.Rows.RemoveAt(grid.SelectedRows[0].Index);
                    grid.Refresh();
                }
            }
        }

        public static void EditRow(DataGridView grid)
        {
            grid.BeginEdit(true);
        }
    }
}
