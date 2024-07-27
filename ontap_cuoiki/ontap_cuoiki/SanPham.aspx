<%@ Page Title="Sản Phẩm" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="ontap_cuoiki.SanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>    
        .imageFlower {
            width: 200px;
            height: 200px;
            object-fit: cover;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" CellSpacing="2">
        <ItemTemplate>
            <asp:Image CssClass="imageFlower" ID="Image1" runat="server" ImageUrl='<%# "~/images/" + Eval("Hinh") %>' />
            <br />
            Tên hoa: <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenHoa") %>'></asp:Label>
            <br />
            Giá: <asp:Label ID="Label2" runat="server" Text='<%# Eval("Dongia", "{0:0,0}") %>'></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Chi tiết sản phẩm" CommandArgument='<%# Eval("MaHoa") %>' OnClick="Button1_Click" />
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
