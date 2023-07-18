<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminmembermanagement.aspx.cs" Inherits="gail_lib.adminmembermanagement" %>
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
                                         <a href="adminbookissuing.aspx"><input type="button" class="btn btn-primary btn-sm" name="Author Management" value="Book Issuing" /></a>
                                         <a href="#"><input type="button" class="btn btn-secondary btn-sm" name="Author Management" value="Member Management" /></a>
                                     <a href="adminbookinventory.aspx"><input type="button" class="btn btn-primary btn-sm" name="Author Management" value="book inventory" /></a>
                                    </div>
                                </div>
            </div>
        </div>
         <hr />
      <div class="row mt-3">
         <div class="col-md-5">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Member Details</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="100px" src="img/teamwork.png" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-4">
                        <label>Member ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" ></asp:TextBox>
                              <asp:LinkButton class="btn btn-primary" ID="LinkButton4" runat="server" OnClick="Go_Click"><i class="fas fa-check-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                     <div class="col-md-3">
                        <label>Full Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"  ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-5">
                        <label>Account Status</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="TextBox7" runat="server" ReadOnly="True" ></asp:TextBox>
                              <asp:LinkButton class="btn btn-success mr-1" ID="LinkButton1" runat="server" OnClick="act_Click"><i class="fas fa-check-circle"></i></asp:LinkButton>
                              <asp:LinkButton class="btn btn-warning mr-1" ID="LinkButton2" runat="server" OnClick="pnd_Click"><i class="far fa-pause-circle"></i></asp:LinkButton>
                              <asp:LinkButton class="btn btn-danger mr-1" ID="LinkButton3" runat="server" OnClick="dis_Click"><i class="fas fa-times-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                  </div>
                  <div class="row mt-3">
                     <div class="col-md-3">
                        <label>DOB</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server"  ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Contact No</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server"  ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-5">
                        <label>Email ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server"  ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row mt-3">
                     <div class="col-md-4">
                        <label>State</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server"  ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>City</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server"  ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Pin Code</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server"  ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row mt-3">
                     <div class="col-12">
                        <label>Full Postal Address</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" TextMode="MultiLine" Rows="2" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>

                  <div class="row mt-3">
                     <div class="col-5 mx-auto">
                        <asp:Button ID="Button2" class="btn btn-sm btn-block btn-danger" runat="server" Text="Delete User Permanently" OnClick="Button2_Click" />
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
                           <h4>Member List</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT &quot;NAME&quot;, &quot;DOB&quot;, &quot;PHONE&quot;, &quot;EMAIL&quot;, &quot;STATE&quot;, &quot;CITY&quot;, &quot;PINCODE&quot;, &quot;ADDRESS&quot;, &quot;USERID&quot;, &quot;PASSWORD&quot;, &quot;ACC_STATUS&quot; FROM &quot;USERS&quot;"></asp:SqlDataSource>
                  <div class="row">
                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="USERID" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:BoundField DataField="USERID" HeaderText="ID" ReadOnly="True" SortExpression="USERID" />
                                <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                                <asp:BoundField DataField="ACC_STATUS" HeaderText="ACC STATUS" SortExpression="ACC_STATUS" />
                                <asp:BoundField DataField="PHONE" HeaderText="PHONE" SortExpression="PHONE" />
                                <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                                <asp:BoundField DataField="STATE" HeaderText="STATE" SortExpression="STATE" />
                                <asp:BoundField DataField="CITY" HeaderText="CITY" SortExpression="CITY" />
                            </Columns>
                         </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
    <br />
    <hr />
    <br />

</asp:Content>
