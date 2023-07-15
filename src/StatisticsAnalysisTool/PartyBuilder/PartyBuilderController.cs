﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using StatisticsAnalysisTool.Models;
using StatisticsAnalysisTool.Models.NetworkModel;
using StatisticsAnalysisTool.Network.Manager;
using StatisticsAnalysisTool.ViewModels;

namespace StatisticsAnalysisTool.PartyBuilder;

public class PartyBuilderController
{
    private readonly TrackingController _trackingController;
    private readonly MainWindowViewModel _mainWindowViewModel;

    public PartyBuilderController(TrackingController trackingController, MainWindowViewModel mainWindowViewModel)
    {
        _trackingController = trackingController;
        _mainWindowViewModel = mainWindowViewModel;
    }

    public async Task UpdatePartyAsync()
    {
        await Application.Current.Dispatcher.InvokeAsync(() =>
        {
            var currentParty = _trackingController?.EntityController?.GetAllEntities(true);
            var bindingsParty = _mainWindowViewModel.PartyBuilderBindings.Party;

            foreach (var item in currentParty?.ToList() ?? new List<KeyValuePair<Guid, PlayerGameObject>>())
            {
                int index = bindingsParty.ToList().FindIndex(x => x.Guid == item.Value.UserGuid);
                if (index >= 0)
                {
                    UpdatePartyPlannerPlayer(item.Value, bindingsParty[index]);
                }
                else
                {
                    bindingsParty.Add(CreatePartyPlannerPlayer(item.Value));
                }
            }

            for (int i = bindingsParty.Count - 1; i >= 0; i--)
            {
                var partyPlannerPlayer = bindingsParty[i];
                int? index = currentParty?.FindIndex(x => x.Value.UserGuid == partyPlannerPlayer.Guid);
                if (index is < 0)
                {
                    bindingsParty.RemoveAt(i);
                }
            }

            _mainWindowViewModel.PartyBuilderBindings.PartyCollectionView.Refresh();
        });
    }

    private PartyBuilderPlayer CreatePartyPlannerPlayer(PlayerGameObject playerGameObject)
    {
        return new PartyBuilderPlayer()
        {
            Guid = playerGameObject.UserGuid,
            Username = playerGameObject.Name,
            MainHand = playerGameObject.CharacterEquipment?.GetMainHand(),
            OffHand = playerGameObject.CharacterEquipment?.GetOffHand(),
            Head = playerGameObject.CharacterEquipment?.GetHead(),
            Chest = playerGameObject.CharacterEquipment?.GetChest(),
            Shoes = playerGameObject.CharacterEquipment?.GetShoes(),
            Bag = playerGameObject.CharacterEquipment?.GetBag(),
            Cape = playerGameObject.CharacterEquipment?.GetCape(),
            Mount = playerGameObject.CharacterEquipment?.GetMount(),
            Potion = playerGameObject.CharacterEquipment?.GetPotion(),
            BuffFood = playerGameObject.CharacterEquipment?.GetBuffFood(),
            MainHandSpells = playerGameObject.CharacterEquipment?.GetMainHandSpells() ?? new List<Spell>(),
            OffHandSpells = playerGameObject.CharacterEquipment?.GetOffHandSpells() ?? new List<Spell>(),
            HeadSpells = playerGameObject.CharacterEquipment?.GetHeadSpells() ?? new List<Spell>(),
            ChestSpells = playerGameObject.CharacterEquipment?.GetChestSpells() ?? new List<Spell>(),
            ShoesSpells = playerGameObject.CharacterEquipment?.GetShoesSpells() ?? new List<Spell>(),
            MountSpells = playerGameObject.CharacterEquipment?.GetMountSpells() ?? new List<Spell>(),
            PotionSpells = playerGameObject.CharacterEquipment?.GetPotionSpells() ?? new List<Spell>(),
            FoodSpells = playerGameObject.CharacterEquipment?.GetFoodSpells() ?? new List<Spell>()
        };
    }

    private void UpdatePartyPlannerPlayer(PlayerGameObject playerGameObject, PartyBuilderPlayer partyBuilderPlayer)
    {
        if (partyBuilderPlayer == null || playerGameObject == null)
        {
            return;
        }

        partyBuilderPlayer.AverageTotalItemPower = (int)Math.Round(playerGameObject.ItemPower, MidpointRounding.AwayFromZero);
        partyBuilderPlayer.MainHand = playerGameObject.CharacterEquipment?.GetMainHand();
        partyBuilderPlayer.OffHand = playerGameObject.CharacterEquipment?.GetOffHand();
        partyBuilderPlayer.Head = playerGameObject.CharacterEquipment?.GetHead();
        partyBuilderPlayer.Chest = playerGameObject.CharacterEquipment?.GetChest();
        partyBuilderPlayer.Shoes = playerGameObject.CharacterEquipment?.GetShoes();
        partyBuilderPlayer.Bag = playerGameObject.CharacterEquipment?.GetBag();
        partyBuilderPlayer.Cape = playerGameObject.CharacterEquipment?.GetCape();
        partyBuilderPlayer.Mount = playerGameObject.CharacterEquipment?.GetMount();
        partyBuilderPlayer.Potion = playerGameObject.CharacterEquipment?.GetPotion();
        partyBuilderPlayer.BuffFood = playerGameObject.CharacterEquipment?.GetBuffFood();
        partyBuilderPlayer.MainHandSpells = playerGameObject.CharacterEquipment?.GetMainHandSpells() ?? new List<Spell>();
        partyBuilderPlayer.OffHandSpells = playerGameObject.CharacterEquipment?.GetOffHandSpells() ?? new List<Spell>();
        partyBuilderPlayer.HeadSpells = playerGameObject.CharacterEquipment?.GetHeadSpells() ?? new List<Spell>();
        partyBuilderPlayer.ChestSpells = playerGameObject.CharacterEquipment?.GetChestSpells() ?? new List<Spell>();
        partyBuilderPlayer.ShoesSpells = playerGameObject.CharacterEquipment?.GetShoesSpells() ?? new List<Spell>();
        partyBuilderPlayer.MountSpells = playerGameObject.CharacterEquipment?.GetMountSpells() ?? new List<Spell>();
        partyBuilderPlayer.PotionSpells = playerGameObject.CharacterEquipment?.GetPotionSpells() ?? new List<Spell>();
        partyBuilderPlayer.FoodSpells = playerGameObject.CharacterEquipment?.GetFoodSpells() ?? new List<Spell>();
    }
}