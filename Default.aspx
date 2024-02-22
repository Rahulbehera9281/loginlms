<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LMS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="height:42px;border:1px solid black;border-radius:4px;padding:3px 3px 3px 3px;background-color:#e4e4e4;">
        <ul style="display:flex;">
            <li style="color:#1C3481; font-size:31px;font-weight:800;padding:4px;">RAMTeCH</li>
            <li style=" font-size:31px;font-weight:200;margin-left:1400px;">Leave Management System</li>
        </ul>
    </div>
    <center>
          <div style="border:1px solid #1C3481;height:49px;width:294px; background-color:#1C3481;margin-top:242px;">
        <div style="margin-top:10px;"><strong style="color:white;font-size:24px ;margin-left:21px;">Login To LMS</strong>&nbsp;&nbsp;&nbsp;&nbsp;</div>
    </div>
        <div style="height:269px;width:294px;border:1px solid #1C3481;margin-top:3px;">
            <div style="float:left;margin-left:28px;margin-top:20px;">
                <strong style="float:left;font-family:Sans-serif;margin-left:12px;">Login with your PM Account</strong><br/>
                
                <strong style="float:left;margin-top:22px;color:blue;margin-left:12px;">Login Name / User Name</strong><br />
                
              <div style="margin-top:31px;">
                  <asp:TextBox ID="TextBox1" runat="server" Height="31px" Width="198px"></asp:TextBox><br />
              </div>  

                 <strong style="float:left;margin-top:17px;color:blue;margin-left:12px;">Password</strong><br />
                <div style="margin-top:25px;">
                    <asp:TextBox ID="TextBox2" runat="server" Height="31px" Width="198px"></asp:TextBox>
                </div>
                <div style="margin-top:10px;">
                    <asp:Button ID="Button1" runat="server" Text="Login" Height="32px" Width="99px" BackColor="Blue" Font-Bold="True" ForeColor="White" OnClick="Button1_Click" />
                </div>
                
                

            </div>
        </div>
    </center>
  
   
</asp:Content>
