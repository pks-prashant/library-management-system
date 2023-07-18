<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminauthormanagement.aspx.cs" Inherits="gail_lib.adminauthormanagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
     <script type="text/javascript">
        /*$(document).ready(function () {
            $('.table').prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable();
        });*/
        /*$(document).ready(function () {
            $('.table').prepend($("<thead></thead>").append($(this).find("tr:first"))).Datatable();
        });*/
        
        $(document).ready( function () {
        $(".table").DataTable();
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row mt-3">
            <div class="col-7 mx-auto">
                <div class="form-group">
                    <div class="">
                        <a href="#">
                            <input type="button" class="btn btn-secondary btn-sm" name="Author Management" value="Author Management" /></a>
                        <a href="adminpublishermanagement.aspx">
                            <input type="button" class="btn btn-primary btn-sm" name="Publisher Management" value="Publisher Management" /></a>
                        <a href="adminbookissuing.aspx">
                            <input type="button" class="btn btn-primary btn-sm" name="Author Management" value="Book Issuing" /></a>
                        <a href="adminmembermanagement.aspx">
                            <input type="button" class="btn btn-primary btn-sm" name="Author Management" value="Member Management" /></a>
                        <a href="adminbookinventory.aspx">
                            <input type="button" class="btn btn-primary btn-sm" name="Author Management" value="book inventory" /></a>
                    </div>
                </div>
            </div>
        </div>
        <hr />
    </div>
    
    <div class="container">
        <div class="row">
            <div class="col-md-4">

                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Author Details</h4>
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="img/editor.png" />

                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-5 ">
                                <label>Author ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Go" OnClick="Button1_Click" />
                                    </div>
                                </div>
                            </div>

                            <div class="col-md-7">
                                <label>Author Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"></asp:TextBox>

                                </div>
                            </div>
                        </div>

                        <div class="row mt-3">
                            <div class="col-4">
                                <asp:Button ID="Button2" class="btn btn-sm btn-block btn-success" runat="server" Text="Add" OnClick="Button2_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button3" class="btn btn-sm btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button4" class="btn btn-sm btn-block btn-danger" runat="server" Text="Delete" OnClick="Button4_Click" />
                            </div>
                        </div>


                    </div>
                </div>


                <br>
            </div>

            <div class="col-md-8">

                <div class="card">
                    <div class="card-body">



                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Author List</h4>
                                </center>
                            </div>
                        </div>



                        <div class="row mt-3">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT &quot;AUTHORID&quot;, &quot;NAME&quot; FROM &quot;AUTHORS&quot;"></asp:SqlDataSource>
                        <div class="row mt-3">
                            <div class="col">
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="AUTHORID" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="AUTHORID" HeaderText="AUTHORID" ReadOnly="True" SortExpression="AUTHORID" />
                                        <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>


                    </div>
                </div>


            </div>

        </div>
    </div>

</asp:Content>
