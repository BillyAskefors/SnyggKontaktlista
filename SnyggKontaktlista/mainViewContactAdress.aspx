<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="mainViewContactAdress.aspx.cs" Inherits="SnyggKontaktlista.WebForm6" %>

<%@ Register Src="~/userControlContacts.ascx" TagPrefix="uc1" TagName="userControlContacts" %>


<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Literal ID="adress_lit" runat="server"></asp:Literal>

    <script>
        function showModal(id, type, street, city) {
            $('input.hiddenID').val(id);
            $('input.type_test').val(type);
            $('input.street_test').val(street);
            $('input.city_test').val(city);
            $('#editModal').modal();
        }
    </script>
    <div class="container">

        <!-- Modal -->
        <div class="modal fade" id="editModal" role="dialog">
            <div class="modal-dialog modal-sm">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Addera adress</h4>
                    </div>
                    <div class="modal-body">
                        <asp:TextBox CssClass="hiddenID" ID="hiddenID" hidden="true" runat="server"></asp:TextBox>
                        <p>Typ av adress</p>
                        <asp:TextBox CssClass="type_test" ID="type_test" runat="server"></asp:TextBox>
                        <p>Gata</p>
                        <asp:TextBox CssClass="street_test" ID="street_test" runat="server"></asp:TextBox>
                        <p>Stad</p>
                        <asp:TextBox CssClass="city_test" ID="city_test" runat="server"></asp:TextBox>
                        
                        <uc1:userControlContacts runat="server" ID="userControlContacts" />
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        <button type="submit" class="btn btn-default" data-submit="modal">Editera</button>
                    </div>
                </div>
            </div>
        </div>
    </div>











    <div class="container">
        <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Addera adress</button>

        <!-- Modal -->
        <div class="modal fade" id="myModal" role="dialog">
            <div class="modal-dialog modal-sm">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Addera adress</h4>
                    </div>
                    <div class="modal-body">

                        <p>Typ av adress</p>
                        <asp:TextBox ID="type" runat="server"></asp:TextBox>
                        <p>Gata</p>
                        <asp:TextBox ID="street" runat="server"></asp:TextBox>
                        <p>Stad</p>
                        <asp:TextBox ID="city" runat="server"></asp:TextBox>

                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        <button type="submit" class="btn btn-default" data-submit="modal">Addera</button>
                    </div>
                </div>
            </div>
        </div>
        <asp:TextBox ID="tb_currentuser" hidden="true" runat="server"></asp:TextBox>
    </div>
</asp:Content>
