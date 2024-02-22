using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalDuel.BL
{
    internal class Player
    {
        public string playerName;
        public double Health;
        private double currentHealth;
        private double maxHealth;
        private double energy;
        private double maxEnergy;
        private double armor;
        private Stats skillStats;

        public Player(string playerName, double Health, double energy, double armor)
        {
            this.playerName = playerName;
            this.Health = Health;
            this.energy = energy;
            this.armor = armor;
        }

        public void UpdateHealth(double amount)
        {
            currentHealth += amount;
            if (currentHealth < 0)
                currentHealth = 0;
            else if (currentHealth > maxHealth)
                currentHealth = maxHealth;
        }

        public void UpdateEnergy(double amount)
        {
            energy += amount;
            if (energy < 0)
                energy = 0;
            else if (energy > maxEnergy)
                energy = maxEnergy;
        }

        public void UpdateArmor(double amount)
        {
            armor += amount;
            if (armor < 0)
                armor = 0;
        }

        public void LearnSkill(Stats stats)
        {
            skillStats = stats;
        }

        public string Attack(Player target)
        {
            if (skillStats == null)
            {
                return $"{playerName} attempted to attack, but hasn't learned any skill yet!";
            }

            if (energy < skillStats.Cost)
            {
                return $"{playerName} attempted to use {skillStats.Name}, but didn't have enough energy!";
            }

            energy -= skillStats.Cost;

            double effectiveArmor = Math.Max(0, target.armor - skillStats.Penetration);
            double calculatedDamage = skillStats.Damage * ((100 - effectiveArmor) / 100);

            target.UpdateHealth(-calculatedDamage);
            UpdateHealth(skillStats.Heal);

            string result = $"{playerName} used {skillStats.Name}, {skillStats.Description}, against {target.playerName}, doing {calculatedDamage} damage!";

            if (skillStats.Heal > 0)
            {
                result += $" {playerName} healed for {skillStats.Heal} health!";
            }

            if (target.currentHealth <= 0)
            {
                result += $" {target.playerName} died.";
            }
            else
            {
                double targetHpPercentage = (target.currentHealth / target.maxHealth) * 100;
                result += $" {target.playerName} is at {targetHpPercentage:F2}% health.";
            }

            return result;
        }
    }
}