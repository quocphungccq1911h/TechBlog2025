﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechBlog2025.Core.Domain.Content
{
    [Table("PostTags")]
    [PrimaryKey(nameof(PostId), nameof(TagId))]
    public class PostTag
    {
        public Guid PostId { set; get; }
        public Guid TagId { set; get; }
    }
}
