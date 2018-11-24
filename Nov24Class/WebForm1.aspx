<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Nov24Class.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #808080;
            background-color: #C0C0C0;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            height: 39px;
        }
        .auto-style6 {
            height: 26px;
            width: 244px;
        }
        .auto-style7 {
            width: 244px;
        }
        .auto-style8 {
            height: 26px;
            width: 267px;
        }
        .auto-style9 {
            width: 267px;
        }
        .auto-style10 {
            height: 26px;
            width: 25px;
        }
        .auto-style11 {
            width: 25px;
        }
        .auto-style12 {
            height: 26px;
            width: 262px;
        }
        .auto-style13 {
            width: 262px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label1" runat="server" Text="Employee No"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style12">
                        <asp:Label ID="Label6" runat="server" Text="Department No"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style13">
                        <asp:Label ID="Label7" runat="server" Text="Department Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label3" runat="server" Text="Designation"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style13">
                        <asp:Button ID="btndeptinsert" runat="server" OnClick="btndeptinsert_Click" Text="Insert  Data" Width="108px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btndeptdisp" runat="server" OnClick="btndeptdisp_Click" Text="Display" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label4" runat="server" Text="Joining Date"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                    <td colspan="2" rowspan="3">
                        <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="196px" Width="296px">
                            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                            <SortedDescendingHeaderStyle BackColor="#242121" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label5" runat="server" Text="Salary"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="btninsert" runat="server" OnClick="btninsert_Click" Text="Insert Emp" Width="117px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btndisp" runat="server" OnClick="btndisp_Click" Text="Display" />
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                    </td>
                    <td class="auto-style9">
                        <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="119px" Width="251px">
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="5">
                        <asp:Button ID="q1" runat="server" OnClick="q1_Click" Text="Query1" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="q2" runat="server" OnClick="q2_Click" Text="Query2" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="q3" runat="server" OnClick="q3_Click" Text="Query3" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="q4" runat="server" OnClick="q4_Click" Text="Query4" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="q5" runat="server" OnClick="q5_Click" Text="Query5" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="q6" runat="server" OnClick="q6_Click" Text="Query6" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="q7" runat="server" OnClick="q7_Click" Text="Query7" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="q8" runat="server" OnClick="q8_Click" Text="Query8" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="q9" runat="server" OnClick="q9_Click" Text="Query9" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="q10" runat="server" OnClick="q10_Click" Text="Query10" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
