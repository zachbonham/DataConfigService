<%@ Control Language="C#" CodeBehind="ForeignKey.ascx.cs" Inherits="ConfigService.Admin.ForeignKeyField" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />

