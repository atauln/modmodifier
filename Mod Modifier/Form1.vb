Imports System.IO
Public Class Form1
    Sub RefreshFiles()
        lvMods.Items.Clear()
        lvArchive.Items.Clear()
        lvLuckyBlocks.Items.Clear()
        Dim ModFiles() As String = IO.Directory.GetFiles("C:\Users\Ataul\AppData\Roaming\.minecraft\mods")
        For Each file As String In ModFiles
            Dim modfilenam = Path.GetFileName(file)
            lvMods.Items.Add(modfilenam)
        Next
        Dim ArchivedFiles() As String = IO.Directory.GetFiles("C:\Users\Ataul\Desktop\KIDS\Archived Mods")
        For Each file As String In ArchivedFiles
            Dim archfilenam = Path.GetFileName(file)
            lvArchive.Items.Add(archfilenam)
        Next
        Dim dir As IO.Directory
        If dir.Exists("C:\Users\Ataul\AppData\Roaming\.minecraft\addons\lucky_block") Then
            Dim LuckyBlockFiles() As String = IO.Directory.GetFiles("C:\Users\Ataul\AppData\Roaming\.minecraft\addons\lucky_block")
            For Each file As String In LuckyBlockFiles
                Dim luckfilenam = Path.GetFileName(file)
                lvLuckyBlocks.Items.Add(luckfilenam)
            Next
        Else
            lvLuckyBlocks.Enabled = False
            btnAddLB.Enabled = False
            btnLuckDel.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshFiles()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not lvMods.SelectedItem.ToString = "" Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Ataul\AppData\Roaming\.minecraft\mods\" + lvMods.SelectedItem)
        End If
        RefreshFiles()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        If Not lvMods.SelectedItem.ToString = "" Then
            My.Computer.FileSystem.MoveFile("C:\Users\Ataul\AppData\Roaming\.minecraft\mods\" + lvMods.SelectedItem, "C:\Users\Ataul\Desktop\KIDS\Archived Mods\" + lvMods.SelectedItem)
        End If
        RefreshFiles()
    End Sub

    Private Sub btnDelArch_Click(sender As Object, e As EventArgs) Handles btnDelArch.Click
        If Not lvArchive.SelectedItem.ToString = "" Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Ataul\Desktop\KIDS\Archived Mods\" + lvArchive.SelectedItem)
        End If
        RefreshFiles()
    End Sub

    Private Sub btnUnArchive_Click(sender As Object, e As EventArgs) Handles btnUnArchive.Click
        If Not lvArchive.SelectedItem.ToString = "" Then
            My.Computer.FileSystem.MoveFile("C:\Users\Ataul\Desktop\KIDS\Archived Mods\" + lvArchive.SelectedItem, "C:\Users\Ataul\AppData\Roaming\.minecraft\mods\" + lvArchive.SelectedItem)
        End If
        RefreshFiles()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnLuckDel.Click
        If Not lvLuckyBlocks.SelectedItem.ToString = "" Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Ataul\AppData\Roaming\.minecraft\addons\lucky_block\" + lvLuckyBlocks.SelectedItem)
        End If
        RefreshFiles()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAddMod.Click
        MsgBox("In order to add a mod, a file dialog will be opened. You musn't hit save or open, just drag your file in.")
        ofdMods.ShowDialog()
    End Sub

    Private Sub btnAddLB_Click(sender As Object, e As EventArgs) Handles btnAddLB.Click
        Dim dir As IO.Directory
        If dir.Exists("C:\Users\Ataul\AppData\Roaming\.minecraft\addons\lucky_block") Then
            MsgBox("In order to add a lucky block addon, a file dialog will be opened. You musn't hit save or open, just drag your file in.")
            ofdLuck.ShowDialog()
        Else
            MsgBox("You have never installed/used the lucky block mod. Please use it once before going to this directory.")
        End If
    End Sub
End Class
