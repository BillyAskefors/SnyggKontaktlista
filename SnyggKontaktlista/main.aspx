<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="SnyggKontaktlista.WebForm4" %>


<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Literal ID="kontakt_lit" runat="server"></asp:Literal>
    
    <script>
         
        function showContactModal(id, firstname, lastname, ssn, action) {
            $('#editModal').modal('show');
            if (action === 'EDIT') {
                $('input.hiddenAction').val(action)
                $('input.hiddenID').val(id);
                $('input.firstname').val(firstname);
                $('input.lastname').val(lastname);
                $('input.ssn').val(ssn);
                $('.buttonName').text('Edit')
                //$('#editModal').modal();
            }
            if (action === 'ADD') {
                $('input.hiddenAction').val(action)
                $('input.hiddenID').val('');
                $('input.firstname').val('');
                $('input.lastname').val('');
                $('input.ssn').val('');
                $('.buttonName').text('Addera')
                //$('#editModal').modal();
            }
        }
        
    </script>
    <div class="container">

        <!-- Modal -->
        <div class="modal fade" id="editModal" role="dialog">
            <div class="modal-dialog modal-sm">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Kontakt</h4>
                    </div>
                    <div class="modal-body">
                        <asp:TextBox CssClass="hiddenAction" ID="hiddenAction" hidden="true" runat="server"></asp:TextBox>
                        <asp:TextBox CssClass="hiddenID" ID="hiddenID" hidden="true" runat="server"></asp:TextBox>
                        <p>Förnamn</p>
                        <asp:TextBox CssClass="firstname" ID="fName" runat="server"></asp:TextBox>
                        <p>Efternamn</p>
                        <asp:TextBox CssClass="lastname" ID="lName" runat="server"></asp:TextBox>
                        <p>SSN</p>
                        <asp:TextBox CssClass="ssn" ID="ssnID" runat="server"></asp:TextBox>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        <button type="submit" class="btn btn-default buttonName" data-submit="modal"></button>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class="container">
        <button type="button" class="btn btn-info btn-lg" onclick="showContactModal('','','','','ADD')">Addera kontakt</button>
    </div>
    <%--<!-- Modal -->
    <div class="modal fade" id="myModal" role="dialog">
        <div class="modal-dialog modal-sm">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Addera kontakt</h4>
                </div>
                <div class="modal-body">
                    <asp:TextBox CssClass="hiddenAction" ID="TextBox1" hidden="true" runat="server">ADD</asp:TextBox>
                    <p>Förnamn</p>
                    <asp:TextBox ID="firstname" runat="server"></asp:TextBox>
                    <p>Efternamn</p>
                    <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
                    <p>SSN</p>
                    <asp:TextBox ID="ssn" runat="server"></asp:TextBox>

                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    <button type="submit" class="btn btn-default" data-submit="modal">Addera</button>
                </div>
            </div>
        </div>
    </div>--%>


</asp:Content>
