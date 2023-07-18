<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="gail_lib.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <%--<script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).Datatable();
        });
    </script>--%>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--     <div class="container">
        <div class="row">
            <div class="col-lg-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <h3>Login</h3>
                            </div>
                        </div>
                        <hr />

                        <div class="row">
                            <div class="col">
                                <label>USERID:</label>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" />
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <label>NAME:</label>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" />
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col" style="font-weight: bolder; color: red;">
                                <asp:Label ID="Lb1" runat="server" Text="Incorrect username or password"></asp:Label>
                            </div>
                        </div>
                        
                        <div class="row mt-3">
                            <div class="col">
                                <asp:LinkButton ID="SearchButton" runat="server" CausesValidation="True" Text="Search" CssClass="btn btn-primary btn-sm mx-auto" Width="100%" OnClick="SearchButton_Click"  />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-6">

                <div class="card">
                    <div class="card-body">
                        <asp:GridView ID="tab" class="table table-striped table-primary" runat="server" HorizontalAlign="Center" Width="400px">
                        </asp:GridView>
                    </div>
                </div>

            </div>
        </div>

         <div class="row mt-5">

             <div class="card">
                 <div class="card-body">
                     <asp:GridView ID="GridView2" runat="server" HorizontalAlign="Center" Width="300px">
                     </asp:GridView>
                 </div> 
             </div>

         </div>
    </div>--%>
</asp:Content>
