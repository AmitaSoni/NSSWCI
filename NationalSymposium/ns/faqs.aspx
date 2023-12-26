<%@ Page Title="" Language="C#" MasterPageFile="~/ns/m.Master" AutoEventWireup="true" CodeBehind="faqs.aspx.cs" Inherits="NationalSymposium.ns.faqs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="h" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="b" runat="server">
    <div class="container-fluid">
    <div class="row">
        <div class="col-sm-12">
            <div class="card">
                <div class="card-header bg-info text-white h5">
                    <i>Faq(s)</i>
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
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>
