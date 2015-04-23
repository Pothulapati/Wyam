﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyam.Core.Modules
{
    public class Content : Module
    {
        private readonly string _content;

        public Content(string content)
        {
            if (content == null)
            {
                throw new ArgumentNullException("content");
            }

            _content = content;
        }

        protected internal override IEnumerable<IModuleContext> Prepare(IModuleContext context)
        {
            return new [] { context };
        }

        protected internal override string Execute(IModuleContext context, string content)
        {
            return _content;
        }
    }
}