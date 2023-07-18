﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminbookissuing.aspx.cs" Inherits="gail_lib.adminbookissuing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row mt-3">
            <div class="col-7 mx-auto">
                                <div class="form-group">
                                    <div class="">
                                        <a href="adminauthormanagement.aspx"><input type="button" class="btn btn-primary btn-sm" name="Author Management" value="Author Management" /></a>
                                        <a href="adminpublishermanagement.aspx"> <input type="button" class="btn btn-primary btn-sm" name="Publisher Management" value="Publisher Management" /></a>
                                         <a href="#"><input type="button" class="btn btn-secondary btn-sm" name="Author Management" value="Book Issuing" /></a>
                                         <a href="adminmembermanagement.aspx"><input type="button" class="btn btn-primary btn-sm" name="Author Management" value="Member Management" /></a>
                                         <a href="adminbookinventory.aspx"><input type="button" class="btn btn-primary btn-sm" name="Author Management" value="book inventory" /></a>
                                    
                                    </div>
                                </div>
            </div>
        </div>
        <hr />
      <div class="row">
         <div class="col-md-5">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Book Issuing</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="100px" src="img/book.png" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row mt-3">
                     <div class="col-md-6">
                        <label>Member ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" ></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Book ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" ></asp:TextBox>
                              <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Go" />
                           </div>
                        </div>
                     </div>
                  </div>
                  <div class="row mt-3">
                     <div class="col-md-6">
                        <label>Member Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" ></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Book Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" ></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row mt-3">
                     <div class="col-md-6">
                        <label>Start Date</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server"  TextMode="Date"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>End Date</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" TextMode="Date"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row mt-3">
                     <div class="col-6">
                        <asp:Button ID="Button2" class="btn btn-sm btn-block btn-primary" runat="server" Text="Issue" OnClick="Button2_Click" />
                     </div>
                     <div class="col-6">
                        <asp:Button ID="Button4" class="btn btn-sm btn-block btn-success" runat="server" Text="Return" />
                     </div>
                  </div>
               </div>
            </div>
         </div>



         <div class="col-md-7">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Issued Book List</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT &quot;USERID&quot;, &quot;BOOKID&quot;, &quot;UNAME&quot;, &quot;BNAME&quot;, &quot;SDATE&quot;, &quot;EDATE&quot; FROM &quot;ISSUE&quot;"></asp:SqlDataSource>
                  <div class="row">
                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="USERID" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:BoundField DataField="USERID" HeaderText="USERID" ReadOnly="True" SortExpression="USERID" />
                                <asp:BoundField DataField="BOOKID" HeaderText="BOOKID" SortExpression="BOOKID" />
                                <asp:BoundField DataField="UNAME" HeaderText="UNAME" SortExpression="UNAME" />
                                <asp:BoundField DataField="BNAME" HeaderText="BNAME" SortExpression="BNAME" />
                                <asp:BoundField DataField="SDATE" HeaderText="SDATE" SortExpression="SDATE" />
                                <asp:BoundField DataField="EDATE" HeaderText="EDATE" SortExpression="EDATE" />
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
