﻿using System;
using System.Collections.Generic;

namespace PTPM.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? OrderNumber { get; set; }

    public int? Quantity { get; set; }

    public int? Discount { get; set; }

    public int? TotalMoney { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual Order? Order { get; set; }
}
