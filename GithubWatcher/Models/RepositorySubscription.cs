﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace GithubWatcher.Models
{
    public class RepositorySubscription : IComparable<RepositorySubscription>
    {
        [Required]
        [Key, Column(Order = 2)]
        public string RepositoryName{ get; set; }
        [Required]
        [Key, Column(Order = 1)]
        public string QQ { get; set; }
        public string Secret { get; set; }    //多对一关联
        [Required]
        public string WebhookId { get; set; }
        [Required]
        public string WebhookName { get; set; }
        [Required]
        public string Type { get; set; }
        public string GroupQQ { get; set; }
        

        public override string ToString()
        {
            return $"{QQ} {RepositoryName} {Secret}\n";
        }

        public int CompareTo(RepositorySubscription other)
        {
            throw new NotImplementedException();
        }
    }
}