<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="userControlContacts.ascx.cs" Inherits="SnyggKontaktlista.userControlContacts" %>



<div id="contactModal">
    <div class="container">
        <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Addera kontakt</button>
    </div>
    <!-- Modal -->
    <div class="modal fade" id="myModal" role="dialog">
        <div class="modal-dialog modal-sm">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Addera kontakt</h4>
                </div>
                <div class="modal-body">

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
    </div>
</div>
