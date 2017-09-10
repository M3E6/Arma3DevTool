Public Class rptFilter


    Private newFilter As String = ""
    Public filters As New List(Of String)

    Private savedFilters As System.Collections.Specialized.StringCollection

    Private Sub rptFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filters = RPTHelper.currentFilters

        For Each item In filters
            ListBox1.Items.Add(item)
        Next

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        newFilter = TextBox2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(newFilter)

        filters.Add(newFilter)
        RPTHelper.currentFilters = filters

        newFilter = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filterObject As Object = ListBox1.SelectedItem
        Dim filterRemove As String = ListBox1.GetItemText(filterObject)

        ListBox1.Items.Remove(filterObject)

        filters.Remove(filterRemove)

        RPTHelper.currentFilters = filters

    End Sub
End Class