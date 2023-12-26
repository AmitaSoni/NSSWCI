<%@ Page Title="" Language="C#" MasterPageFile="~/ns/m.Master" AutoEventWireup="true" CodeBehind="a_faqs.aspx.cs" Inherits="NationalSymposium.ns.a_faqs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="h" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="b" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12">
                <div class="card">
                    <div class="card-header bg-info text-white h5">
                        <i>View Faq(s)</i>
                    </div>
                    <div class="card-body">
                        <asp:GridView runat="server" ID="gvFaq" AutoGenerateColumns="false" EmptyDataText="No records found" Width="100%" CssClass="table table-hover table-striped table-condensed table-bordered table-sm" OnPreRender="gvFaq_PreRender">
                            <Columns>
                                <asp:TemplateField HeaderText="Sl. No.">
                                    <ItemTemplate>
                                        <%#Container.DataItemIndex +1 %>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                                </asp:TemplateField>
                                <asp:BoundField DataField="FaqQuestions" HeaderText="Questions" />
                                <asp:BoundField DataField="FaqAnswers" HeaderText="Answers" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button ID="bDelete" CssClass="btn btn-danger btn-sm" runat="server" Text="Delete" OnClick="bDelete_Click" OnClientClick="return confirm('Do you want to delete?');" CommandArgument='<%#Eval("FaqId") %>' CausesValidation="false" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                <asp:Button ID="bAddFaq" runat="server" Text="Add Faq" CssClass="btn btn-primary btn-lg" OnClick="bAddFaq_Click" />
            </div>
        </div>
    </div>
    <div class="container">
        <div class="col-md-12">
            <asp:Panel runat="server" ID="paddFaq" Visible="false" CssClass="card">
                <div class="card-header"></div>
                <div class="card-body">
                    <div class="row">

                        <div class="col-sm-6">
                            <div class="form-group">
                                <label>Questions <span class="text-danger">(*)</span></label>
                                <asp:TextBox ID="txtQuestion" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvQuestions" ControlToValidate="txtQuestion" runat="server" ErrorMessage="Please provide the question." CssClass="text-danger"></asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="form-group">
                                <label>Answers <span class="text-danger">(*)</span></label>
                                <asp:TextBox ID="txtAnswers" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvAnswers" ControlToValidate="txtAnswers" runat="server" ErrorMessage="Please provide the answer." CssClass="text-danger"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12 text-center">
                            <asp:Button ID="bSubmit" runat="server" Text="Save" OnClick="bSubmit_Click" CssClass="btn btn-success btn-sm" />
                            <asp:Button ID="bViewAll" runat="server" Text="View All" OnClick="bViewAll_Click" CssClass="btn btn-primary btn-sm" CausesValidation="false" />
                        </div>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
