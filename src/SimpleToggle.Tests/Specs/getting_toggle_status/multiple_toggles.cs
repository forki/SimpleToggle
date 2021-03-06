﻿using Shouldly;
using SimpleToggle.Tests.Specs._contexts;
using Xunit;

namespace SimpleToggle.Tests.Specs.getting_toggle_status
{
    public class multiple_toggles : toggle_context
    {
        public multiple_toggles()
        {
            toggle_on<MyToggle>();
            toggle_on<MyOtherToggle>();
            toggle_off<MyOtherOffToggle>();
        }

        [Fact]
        public void can_have_different_values()
        {
            is_toggle_enabled<MyToggle>().ShouldBe(true);
            is_toggle_enabled<MyOtherToggle>().ShouldBe(true);
            is_toggle_enabled<MyOtherOffToggle>().ShouldBe(false);
        }
    }
}