<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="wed.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <%--start--%>
    <form id="form1" runat="server">
        <div style="font-family: DilleniaUPC; font-size: xx-large; color: #3366FF; font-style: normal; text-transform: none; background-color: #FFFFCC; text-align: center;">
            <h1>เครื่องคำนวน BMI</h1>
        </div>
        <div>
            <h3 style="text-align: center">โปรดป้อนจำนวนเต็มส่วนสูง(หน่วยเป็นเซ็นติเมตร) และ น้ำหนัก(หน่วยเป็นกิโลกรัม)</h3>
            <p style="text-align: center">&nbsp;</p>

        </div>
        <div style="text-align: center;">

            <label for="wight">น้ำหนัก(กิโลกรัม):</label><asp:TextBox ID="tb1" runat="server"></asp:TextBox>
            <br>
            <br>
            <label for="hight">ส่วนสูง(เซ็นติเมตร):<asp:TextBox ID="tb2" runat="server"></asp:TextBox>
            <br />
            <br />
            </label>

                &nbsp;

            <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="คำนวน" Width="89px" />

            <br />
            <br />
            <asp:Label ID="show" runat="server" BorderStyle="Groove" Height="64px" Text="BMI" Width="263px"></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" />
            <br />
            <br />
           
          


            
        </div>
        



    </form>
</body>
</html>
