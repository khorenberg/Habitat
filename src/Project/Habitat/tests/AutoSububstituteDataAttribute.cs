﻿namespace Sitecore.Habitat.Website.Tests
{
  using Ploeh.AutoFixture.AutoNSubstitute;
  using Ploeh.AutoFixture.Xunit2;

  public class AutoSububstituteDataAttribute : AutoDataAttribute
  {
    public AutoSububstituteDataAttribute()
    {
      this.Fixture.Customize(new AutoNSubstituteCustomization());
    }
  }
}