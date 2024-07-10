using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace TaskManagmentSystem
{
    public partial class Form1 : Form
    {
        private TareaConcreta tareaPrincipal;

        public Form1()
        {
            InitializeComponent();
            tareaPrincipal = new TareaConcreta("Proyecto Principal");
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            treeViewTasks.Nodes.Clear();
            TreeNode nodoPrincipal = new TreeNode(tareaPrincipal.Nombre);
            nodoPrincipal.Tag = tareaPrincipal;
            treeViewTasks.Nodes.Add(nodoPrincipal);
            AñadirNodos(nodoPrincipal, tareaPrincipal);
            treeViewTasks.ExpandAll();
        }

        private void AñadirNodos(TreeNode nodoPadre, ITarea tarea)
        {
            foreach (var subtarea in tarea.GetSubtareas())
            {
                TreeNode nuevoNodo = new TreeNode(subtarea.Nombre);
                nuevoNodo.Tag = subtarea;
                nodoPadre.Nodes.Add(nuevoNodo);
                AñadirNodos(nuevoNodo, subtarea);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (treeViewTasks.SelectedNode != null)
            {
                var tareaSeleccionada = (ITarea)treeViewTasks.SelectedNode.Tag;
                var nuevaTarea = new TareaConcreta("Nueva Tarea");
                tareaSeleccionada.AddSubtarea(nuevaTarea);
                ActualizarVista();
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (treeViewTasks.SelectedNode != null && treeViewTasks.SelectedNode.Parent != null)
            {
                var tareaPadre = (ITarea)treeViewTasks.SelectedNode.Parent.Tag;
                var tareaSeleccionada = (ITarea)treeViewTasks.SelectedNode.Tag;
                tareaPadre.RemoveSubtarea(tareaSeleccionada);
                ActualizarVista();
            }
        }

        private void btnChangeState_Click(object sender, EventArgs e)
        {
            if (treeViewTasks.SelectedNode != null)
            {
                var tareaSeleccionada = (TareaConcreta)treeViewTasks.SelectedNode.Tag;
                tareaSeleccionada.AvanzarEstado();
                ActualizarVista();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
