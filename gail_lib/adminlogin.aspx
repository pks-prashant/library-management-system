<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="gail_lib.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
       
        <hr />
        <div class="row">
            <div class="col-lg-6 mx-auto">
                <div class="card">
                    

                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="img/admin.png" alt="Oops!" height="100" />
                                     <h3>Admin Login</h3>
                                </center>  
                            </div>
                        </div>
                        <hr />
                        <div class="row">
                            <div class="col">
                                <label>Admin Id</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" ></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        
                        <div class="row mt-3">
                            <div class="col">
                                <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Password" ></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row mt-3">
                            <div class="col" style="font-weight: bolder; color: red;">
                                <asp:Label ID="Lb1" runat="server" Text="Incorrect AdminId or Password"></asp:Label>
                            </div>
                        </div>
                        
                            <div class="from-group" style="float:right;">
                                <asp:Button runat="server" Text="Login" CssClass="btn btn-success btn-block mt-3" OnClick="login_Click" />
                            </div>
                    </div>

                    <div class="card-footer">
                        <center>
                        <div class="row">
                            <a href="#"><input type="button"  class="btn btn-default" name="Reset" value="Reset Password" /></a>
                        </div>
                        </center>  
                    </div>
                </div>
            </div>
        </div>
    </div>  
</asp:Content>
