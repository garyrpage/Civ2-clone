using Civ2engine;
using Model.Core.GoodyHuts.Outcomes;
using Model.Core.Units;

namespace Core.Tests.Units;

public class GoldOutcomeTests
{
    [Fact]
    public void ApplyOutcome_IncreasesOwnerMoneyBySpecifiedAmount()
    {
        // Arrange
        var initialMoney = 100;
        var goldAmount = 50;
        var owner = new Civilization { Money = initialMoney };
        var unit = new Unit { Owner = owner };
        var goldOutcome = new GoldOutcome(goldAmount);

        // Act
        goldOutcome.ApplyOutcome(unit);

        // Assert
        Assert.Equal(initialMoney + goldAmount, owner.Money);
    }

    [Fact]
    public void ApplyOutcome_ReturnsGoldAmountInReplaceNumbers()
    {
        // Arrange
        var goldAmount = 75;
        var unit = new Unit { Owner = new Civilization() };
        var goldOutcome = new GoldOutcome(goldAmount);

        // Act
        var result = goldOutcome.ApplyOutcome(unit);

        // Assert
        Assert.Equal([goldAmount], result.ReplaceNumbers);
    }

    [Fact]
    public void ApplyOutcome_ReturnsGoldOutcomeType()
    {
        // Arrange
        var unit = new Unit { Owner = new Civilization() };
        var goldOutcome = new GoldOutcome(50);

        // Act
        var result = goldOutcome.ApplyOutcome(unit);

        // Assert
        Assert.Equal("Gold", result.OutcomeType);
    }
}
