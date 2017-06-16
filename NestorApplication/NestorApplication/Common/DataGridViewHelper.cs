using NestorRepository;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static void Add(DataTable dataTable, DataGridView grid, Button btnZapisz)
        {
            dataTable.Rows.Add();
            grid.ReadOnly = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            grid.Rows[grid.Rows.Count - 1].Selected = true;

            DataGridViewCell cell = grid.Rows[grid.Rows.Count - 1].Cells[1];
            grid.CurrentCell = cell;
            grid.BeginEdit(true);

            btnZapisz.Enabled = true;
        }

        public static void Edit(DataGridView grid, Button btnZapisz)
        {
            grid.ReadOnly = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            grid.BeginEdit(true);
            btnZapisz.Enabled = true;
        }

        public static void Delete(DataGridView grid, List<int> recordsToDeleted, Button btnZapisz, Func<int, bool> check)
        {
            int id = -1;
            if (grid.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno usunąć zaznaczony rekord ?", "Usuwanie danych", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    id = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (check.Invoke(id))
                    {
                        grid.Rows.RemoveAt(grid.SelectedRows[0].Index);
                        grid.Refresh();
                        btnZapisz.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Nie można usunąć rekordu dla którego zapisano pomiar.", "Usuwanie danych", MessageBoxButtons.OK);
                    }
                }
            }
           
            if (id >= 0)
            {
                recordsToDeleted.Add(id);
            }
        }

        public static void Save(DataGridView grid, string tableName, DataTable dataTable, List<int> recordsToDeleted, Button btnZapisz, Action<DataRow> add, Action<DataRow> update)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                switch (row.RowState)
                {
                    case DataRowState.Added:
                        add.Invoke(row);
                        row.AcceptChanges();
                        break;

                    case DataRowState.Modified:
                        update.Invoke(row);
                        row.AcceptChanges();
                        break;
                }
            }

            foreach (int id in recordsToDeleted)
            {
                DatabaseHelper.DeleteRecord(tableName, id);
            }

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Refresh();
            grid.ReadOnly = true;

            btnZapisz.Enabled = false;

            MessageBox.Show("Pomyślnie zapisano zmiany.", "Zapis danych");
        }
    }
}
