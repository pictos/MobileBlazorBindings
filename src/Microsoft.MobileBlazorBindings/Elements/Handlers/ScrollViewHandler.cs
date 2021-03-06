﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Microsoft.MobileBlazorBindings.Core;
using XF = Xamarin.Forms;

namespace Microsoft.MobileBlazorBindings.Elements.Handlers
{
    public class ScrollViewHandler : LayoutHandler
    {
        public ScrollViewHandler(NativeComponentRenderer renderer, XF.ScrollView scrollViewControl) : base(renderer, scrollViewControl)
        {
            ScrollViewControl = scrollViewControl ?? throw new System.ArgumentNullException(nameof(scrollViewControl));
        }

        public XF.ScrollView ScrollViewControl { get; }

        public override void ApplyAttribute(ulong attributeEventHandlerId, string attributeName, object attributeValue, string attributeEventUpdatesAttributeName)
        {
            switch (attributeName)
            {
                case nameof(XF.ScrollView.HorizontalScrollBarVisibility):
                    ScrollViewControl.HorizontalScrollBarVisibility = (XF.ScrollBarVisibility)AttributeHelper.GetInt(attributeValue);
                    break;
                case nameof(XF.ScrollView.Orientation):
                    ScrollViewControl.Orientation = (XF.ScrollOrientation)AttributeHelper.GetInt(attributeValue);
                    break;
                case nameof(XF.ScrollView.VerticalScrollBarVisibility):
                    ScrollViewControl.VerticalScrollBarVisibility = (XF.ScrollBarVisibility)AttributeHelper.GetInt(attributeValue);
                    break;
                default:
                    base.ApplyAttribute(attributeEventHandlerId, attributeName, attributeValue, attributeEventUpdatesAttributeName);
                    break;
            }
        }
    }
}
