<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CouleursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FondToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TexteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DefautToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MisesÀJoursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Horloge.My.MySettings.Default, "label1_forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 70.0!)
        Me.Label1.ForeColor = Global.Horloge.My.MySettings.Default.label1_forecolor
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(563, 328)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CouleursToolStripMenuItem, Me.ToolStripSeparator1, Me.MisesÀJoursToolStripMenuItem, Me.AProposToolStripMenuItem, Me.ToolStripSeparator3, Me.QuitterToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(143, 104)
        '
        'CouleursToolStripMenuItem
        '
        Me.CouleursToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FondToolStripMenuItem, Me.TexteToolStripMenuItem, Me.ToolStripSeparator2, Me.DefautToolStripMenuItem})
        Me.CouleursToolStripMenuItem.Name = "CouleursToolStripMenuItem"
        Me.CouleursToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CouleursToolStripMenuItem.Text = "Couleurs"
        '
        'FondToolStripMenuItem
        '
        Me.FondToolStripMenuItem.Name = "FondToolStripMenuItem"
        Me.FondToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.FondToolStripMenuItem.Text = "Fond"
        '
        'TexteToolStripMenuItem
        '
        Me.TexteToolStripMenuItem.Name = "TexteToolStripMenuItem"
        Me.TexteToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.TexteToolStripMenuItem.Text = "Texte"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(125, 6)
        '
        'DefautToolStripMenuItem
        '
        Me.DefautToolStripMenuItem.Name = "DefautToolStripMenuItem"
        Me.DefautToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DefautToolStripMenuItem.Text = "Par defaut"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(139, 6)
        '
        'MisesÀJoursToolStripMenuItem
        '
        Me.MisesÀJoursToolStripMenuItem.Enabled = False
        Me.MisesÀJoursToolStripMenuItem.Name = "MisesÀJoursToolStripMenuItem"
        Me.MisesÀJoursToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.MisesÀJoursToolStripMenuItem.Text = "Mises à jours"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AProposToolStripMenuItem.Text = "A propos"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(139, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Horloge.My.MySettings.Default, "label2_forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label2.ForeColor = Global.Horloge.My.MySettings.Default.label2_forecolor
        Me.Label2.Location = New System.Drawing.Point(12, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fait un clique droit pour afficher les options !"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = Global.Horloge.My.MySettings.Default.checkbox1_checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Horloge.My.MySettings.Default, "checkbox1_checked", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(443, 323)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(132, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Masquer les secondes"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Horloge.My.MySettings.Default.form1_backcolor
        Me.ClientSize = New System.Drawing.Size(587, 346)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Horloge.My.MySettings.Default, "form1_backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horloge"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CouleursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FondToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MisesÀJoursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents TexteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DefautToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CheckBox1 As CheckBox
End Class
