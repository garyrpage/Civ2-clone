using Civ2engine;
using Model.Core.GoodyHuts.Outcomes;
using Model.Core.Units;

namespace Core.Tests.Units;

public class BarbariansOutcomeTests
{
    [Fact]
    public void ApplyOutcome_ReturnsCorrectOutcomeType()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new BarbariansOutcome().ApplyOutcome(unit);
        Assert.Equal("Barbarians", result.OutcomeType);
    }

    [Fact]
    public void ApplyOutcome_ReturnsCorrectDialogKey()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new BarbariansOutcome().ApplyOutcome(unit);
        Assert.Equal("SURPRISEBARB", result.Message);
    }

    [Fact]
    public void ApplyOutcome_ReturnsSuccess()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new BarbariansOutcome().ApplyOutcome(unit);
        Assert.True(result.Success);
    }
}

public class MercenariesOutcomeTests
{
    [Fact]
    public void ApplyOutcome_ReturnsCorrectOutcomeType()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new MercenariesOutcome().ApplyOutcome(unit);
        Assert.Equal("Mercenaries", result.OutcomeType);
    }

    [Fact]
    public void ApplyOutcome_ReturnsCorrectDialogKey()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new MercenariesOutcome().ApplyOutcome(unit);
        Assert.Equal("SURPRISEMERCS", result.Message);
    }

    [Fact]
    public void ApplyOutcome_ReturnsSuccess()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new MercenariesOutcome().ApplyOutcome(unit);
        Assert.True(result.Success);
    }
}

public class ScrollsOutcomeTests
{
    [Fact]
    public void ApplyOutcome_ReturnsCorrectOutcomeType()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new ScrollsOutcome().ApplyOutcome(unit);
        Assert.Equal("Scrolls", result.OutcomeType);
    }

    [Fact]
    public void ApplyOutcome_ReturnsCorrectDialogKey()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new ScrollsOutcome().ApplyOutcome(unit);
        Assert.Equal("SURPRISESCROLLS", result.Message);
    }

    [Fact]
    public void ApplyOutcome_ReturnsSuccess()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new ScrollsOutcome().ApplyOutcome(unit);
        Assert.True(result.Success);
    }
}

public class AdvancedTribeOutcomeTests
{
    [Fact]
    public void ApplyOutcome_ReturnsCorrectOutcomeType()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new AdvancedTribeOutcome().ApplyOutcome(unit);
        Assert.Equal("Tribe", result.OutcomeType);
    }

    [Fact]
    public void ApplyOutcome_ReturnsCorrectDialogKey()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new AdvancedTribeOutcome().ApplyOutcome(unit);
        Assert.Equal("SURPRISETRIBE", result.Message);
    }

    [Fact]
    public void ApplyOutcome_ReturnsSuccess()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new AdvancedTribeOutcome().ApplyOutcome(unit);
        Assert.True(result.Success);
    }
}

public class NomadsOutcomeTests
{
    [Fact]
    public void ApplyOutcome_ReturnsCorrectOutcomeType()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new NomadsOutcome().ApplyOutcome(unit);
        Assert.Equal("Nomads", result.OutcomeType);
    }

    [Fact]
    public void ApplyOutcome_ReturnsCorrectDialogKey()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new NomadsOutcome().ApplyOutcome(unit);
        Assert.Equal("SURPRISENOMADS", result.Message);
    }

    [Fact]
    public void ApplyOutcome_ReturnsSuccess()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new NomadsOutcome().ApplyOutcome(unit);
        Assert.True(result.Success);
    }
}

public class AbandonedVillageOutcomeTests
{
    [Fact]
    public void ApplyOutcome_ReturnsCorrectOutcomeType()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new AbandonedVillageOutcome().ApplyOutcome(unit);
        Assert.Equal("Nothing", result.OutcomeType);
    }

    [Fact]
    public void ApplyOutcome_ReturnsCorrectDialogKey()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new AbandonedVillageOutcome().ApplyOutcome(unit);
        Assert.Equal("SURPRISENOTHING", result.Message);
    }

    [Fact]
    public void ApplyOutcome_ReturnsSuccess()
    {
        var unit = new Unit { Owner = new Civilization() };
        var result = new AbandonedVillageOutcome().ApplyOutcome(unit);
        Assert.True(result.Success);
    }
}
