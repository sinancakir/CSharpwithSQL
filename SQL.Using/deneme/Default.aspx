<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="deneme.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        .txtbox
    {
        margin-bottom: 0px;
            height: 22px;
        }
    
    .btn
    {
        background:grey;
        width:140px;
        height:40px;
        border:3px solid;

    }  
    
     .txt
    {
        font-family:Comic Sans MS;
        font-size:medium;
    } 
        .style1
        {
            width: 75%;
            border-style: solid;
            border-width: 3px
        }
        .style2
        {
            width: 75%;
            border-style: solid;
            border-width: 3px;
        }
        .style4
        {
            width: 260px;
        }
    </style>
   

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView align="center" ID="GridView1" runat="server" BackColor="#DEBA84" 
            BorderColor="#DEBA84" BorderStyle="Groove" BorderWidth="2px" CellPadding="5" 
            CellSpacing="5" Width="750px" Height="250px">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <br />
        <br />
        <center>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
            Text="Ekle Panelini Aç" class="btn" Font-Bold="True" />
&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Sil Panelini Aç" 
          class="btn" Font-Bold="True" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
            Text="Update Panelini Aç" class="btn" Font-Bold="True"/>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" onclick="Button7_Click" 
            Text="Paneli kapat" class="btn" Font-Bold="True"/>
        <br />
        <br /></center>
        <asp:Panel ID="Panel1" runat="server">

        <div id="div_ekle" class="div_ortak" style="border:2px solid green; background-color:grey" >
            <asp:Panel ID="eklepanel" runat="server">

                
                <br />
                <table align="center" border="3" cellpadding="5" cellspacing="5" class="style1">
                    <tr>
                        <td class="style4">
                            İsim</td>
                        <td>
                            <asp:TextBox ID="txtisim" runat="server" class="txtbox" Height="16px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtisim" ErrorMessage="* Bu Alan Boş Bırakılamaz" 
                                Font-Bold="True" ForeColor="#CC0000" ValidationGroup="ekle"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            Bölüm</td>
                        <td>
                            <asp:TextBox ID="txtbolum" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ErrorMessage="* Bu Alan Boş Bırakılamaz" ControlToValidate="txtbolum" 
                                Font-Bold="True" ForeColor="#CC0000" ValidationGroup="ekle"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            Sınıf</td>
                        <td>
                            <asp:TextBox ID="txtsinif" runat="server" class="txtbox"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ErrorMessage="* Bu Alan Boş Bırakılamaz" ControlToValidate="txtsinif" 
                                Font-Bold="True" ForeColor="#CC0000" ValidationGroup="ekle"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            Yaş</td>
                        <td>
                            <asp:TextBox ID="txtyas" runat="server" class="txtbox"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ErrorMessage="* Bu Alan Boş Bırakılamaz" ControlToValidate="txtyas" 
                                Font-Bold="True" ForeColor="#CC0000" ValidationGroup="ekle"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Ekle" 
                                ValidationGroup="ekle" Width="50px" />
                        </td>
                    </tr>
                </table>

                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
            
            </asp:Panel>
            </div>
            <br />
            <div id="div2" class="div_ortak" style="border:2px solid green; background-color:grey" >
            <asp:Panel ID="silpanel" runat="server">
                <br />
                <table cellpadding="5" cellspacing="5" class="style2" border="3" align="center">
                    <tr>
                        <td class="style4" align="left">
                            Ögrenci Nosu</td>
                        <td>
                            <asp:TextBox ID="txtnosil" runat="server" class=txtbox></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                ControlToValidate="txtnosil" ErrorMessage="* Bu Alan Boş Bırakılamaz" 
                                Font-Bold="True" ForeColor="#CC0000" ValidationGroup="sil"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4" align="center">
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="Sil" 
                                Width="50px" ValidationGroup="sil" />
                        </td>
                    </tr>
                </table>
                <br />
            </asp:Panel>
            </div>
            <br />
            <div id="div3" class="div_ortak" style="border:2px solid green; background-color:grey" >
            <asp:Panel ID="guncellepanel" runat="server">
                <br />
                <table align="center" border="3" cellpadding="5" cellspacing="5" class="style2">
                    <tr>
                        <td align="left" class="style4">
                            Güncellenecek Ögrencinin Nosu&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                                
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style4">
                            İsim&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td>
                            <asp:TextBox ID="txtisim0" runat="server" class="txtbox" 
                               ></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style4">
                            Bölüm</td>
                        <td>
                            <asp:TextBox ID="txtbolum0" runat="server" class="txtbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style4">
                            Sınıf&nbsp;</td>
                        <td>
                            <asp:TextBox ID="txtsinif0" runat="server" class="txtbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style4">
                            Yaş</td>
                        <td>
                            <asp:TextBox ID="txtyas0" runat="server" class="txtbox"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ControlToValidate="txtyas0" ErrorMessage="* Sayısal bir deger girin" 
                                ValidationExpression="\d{2} " ValidationGroup="guncelle"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="Button6" runat="server" onclick="Button6_Click" Text="Güncelle" 
                                Width="96px" ValidationGroup="guncelle" />
                        </td>
                    </tr>
                </table>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
            </asp:Panel>
            </div>
        </asp:Panel>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
