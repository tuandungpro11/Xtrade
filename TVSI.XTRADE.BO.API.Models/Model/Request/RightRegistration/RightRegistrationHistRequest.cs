﻿namespace TVSI.XTRADE.BO.API.Models.Model.Request.RightRegistration;

public class RightRegistrationHistRequest : RightRegistrationHistExportRequest
{
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}