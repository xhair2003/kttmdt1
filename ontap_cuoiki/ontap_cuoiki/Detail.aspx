<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="ontap_cuoiki.Detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .product_detail {
            display: flex;
            gap: 20px;
            align-items: flex-start;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <div class="product_detail">
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/" + Eval("Hinh") %>' />
                <div class="product_detail-content">
                    Tên hàng:
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenHoa") %>'></asp:Label>
                    <br />
                    Mô tả:
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Mota") %>'></asp:Label>
                    <br />
                    Đơn giá:
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("Dongia", "{0:0,0}") %>'></asp:Label>
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>