using System.Collections.Specialized;
using Microsoft.EntityFrameworkCore;
using Model.Entities.Abilities;
using Model.Entities.Authors;
using Model.Entities.Books;
using Model.Entities.Creatures;
using Model.Entities.Effects;
using Model.Entities.Events;
using Model.Entities.Events.SubEvents;
using Model.Entities.Events.SubEvents.ItemEvents;
using Model.Entities.Events.SubEvents.ValueEffects;
using Model.Entities.Heroes;
using Model.Entities.Heroes.Inventories;
using Model.Entities.Items;
using Model.Entities.Items.SubItems;
using Model.Entities.Outcomes;
using Model.Entities.Outcomes.SubOutcomes;
using Model.Entities.Regions;
using Model.Entities.Sections;
using Model.Entities.Sections.RuleSections;
using Model.Entities.Sections.StorySections;
using Model.Entities.Sessions;
using Model.Entities.Users;
using PlayerLevel = Model.Entities.Heroes.PlayerLevels.PlayerLevel;

namespace Model.Configuration; 

public class PlaybookContext : DbContext {

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Occupation> BookOccupations { get; set; }
    
    public DbSet<PlayerLevel> PlayerLevels { get; set; }

    public DbSet<Ability> Abilities { get; set; }

    public DbSet<ARegion> Regions { get; set; }
    public DbSet<Area> Areas { get; set; }
    public DbSet<PointsOfInterest> PointsOfInterests { get; set; }

    public DbSet<AItem> Items { get; set; }

    public DbSet<ASection> ASections { get; set; }
    public DbSet<ImageDecorator> ImageDecorators { get; set; }
    
    public DbSet<RuleSection> RuleSections { get; set; }
    public DbSet<StorySection> StorySections { get; set; }

    public DbSet<AOutcome> AOutcomes { get; set; }
    public DbSet<AbilityOutcome> AbilityOutcomes { get; set; }
    public DbSet<DefaultOutcome> DefaultOutcomes { get; set; }
    public DbSet<GoldOutcome> GoldOutcomes { get; set; }
    public DbSet<ItemOutcome> ItemOutcomes { get; set; }
    public DbSet<MissionFailedOutcome> FailedOutcomes { get; set; }
    public DbSet<RandomOutcome> RandomOutcomes { get; set; }

    public DbSet<Creature> Creatures { get; set; }
    public DbSet<CreatureAbility> CreatureAbilities { get; set; }

    public DbSet<Effect> Effects { get; set; }
    public DbSet<AbilityEffect> AbilityEffects { get; set; }
    public DbSet<CombatSkillEffect> CombatSkillEffects { get; set; }
    public DbSet<EnduranceEffect> EnduranceEffects { get; set; }
    public DbSet<ItemEffect> ItemEffects { get; set; }
    public DbSet<ValueEffect> ValueEffects { get; set; }

    public DbSet<AEvent> Events { get; set; }
    public DbSet<AItemEvent> AItemEvents { get; set; }
    public DbSet<AcquireItemEvent> AcquireItemEvents { get; set; }
    public DbSet<DropBackpackEvent> DropBackpackEvents { get; set; }
    public DbSet<DropItemEvent> DropItemEvents { get; set; }
    public DbSet<AValueEvent> ValueEvents { get; set; }
    public DbSet<CombatSkillEvent> CombatSkillEvents { get; set; }
    public DbSet<CombatSkillTempChangeEvent> CombatSkillTempChangeEvents { get; set; }
    public DbSet<EnduranceEvent> EnduranceEvents { get; set; }
    public DbSet<GoldAmountEvent> GoldAmountEvents { get; set; }
    public DbSet<RationAmountEvent> RationAmountEvents { get; set; }
    public DbSet<CombatEvent> CombatEvents { get; set; }
    public DbSet<DropAllWeaponEvent> DropAllWeaponEvents { get; set; }
    public DbSet<DropWeaponEvent> DropWeaponEvents { get; set; }
    public DbSet<MissionAccomplishedEvent> MissionAccomplishedEvents { get; set; }
    public DbSet<MissionFailedEvent> MissionFailedEvents { get; set; }
    public DbSet<StoryEvent> StoryEvents { get; set; }

    public DbSet<User> Users { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<UserRoleClaim> RoleClaims { get; set; }

    public DbSet<Session> Sessions { get; set; }
    public DbSet<PlayedBook> PlayedBooks { get; set; }

    public DbSet<Hero> Heroes { get; set; }
    public DbSet<HeroOwnership> HeroOwnerships { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<InventoryItem> InventoryItems { get; set; }
    public DbSet<SectionHistory> SectionHistories { get; set; }
    public DbSet<HeroAbility> HeroAbilities { get; set; }
    
    public PlaybookContext(DbContextOptions<PlaybookContext> options) : base(options) {
        
    }
    protected override void OnModelCreating(ModelBuilder builder) {
        
        // BookOccupations - BOOK_HAS_AUTHORS_JT
        builder.Entity<Occupation>().HasKey(bo => new {bo.BookId, bo.AuthorId, bo.OccupationType});
        builder.Entity<Occupation>().HasOne(bo => bo.Book)
            .WithMany()
            .HasForeignKey(bo => bo.BookId);
        builder.Entity<Occupation>().HasOne(bo => bo.Author)
            .WithMany()
            .HasForeignKey(bo => bo.AuthorId);
        builder.Entity<Occupation>().Property(bo => bo.OccupationType).HasConversion<string>();
        
        // PlayerLevel - PLAYER_LEVEL
        builder.Entity<PlayerLevel>().Property(pl => pl.Level).HasConversion<string>();
        
        // Ability - ABILITIES
        builder.Entity<Ability>().Property(a => a.Type).HasConversion<string>();
        
        // ARegion - REGIONS_BT
        builder.Entity<ARegion>().Property(r => r.RegionType).HasConversion<string>();
        builder.Entity<ARegion>().HasOne(r => r.Area)
            .WithMany()
            .HasForeignKey(r => r.AreaId);
        
        // AItems - ITEMS_ST
        builder.Entity<AItem>().HasDiscriminator<string>("ITEM_TYPE")
            .HasValue<BackPack>("BACK_PACK")
            .HasValue<Key>("KEY")
            .HasValue<MagicalItem>("MAGICAL_ITEM")
            .HasValue<Potion>("POTION")
            .HasValue<Scroll>("SCROLL")
            .HasValue<Utility>("UTILITY")
            .HasValue<Weapon>("WEAPON");
        
        builder.Entity<AItem>().Property(i => i.Weight).HasConversion<string>();
        
        // ASection - SECTIONS_BT
        builder.Entity<ASection>().HasOne(s => s.Book)
            .WithMany()
            .HasForeignKey(s => s.BookId);
        
        // RuleSection - RULE_SECTIONS
        builder.Entity<RuleSection>().Property(rs => rs.SectionType).HasConversion<string>();

        // StorySection - STORY_SECTIONS
        builder.Entity<StorySection>().HasOne<ARegion>(s => s.Region)
            .WithMany()
            .HasForeignKey(s => s.RegionId);
        
        // ImageDecorators - IMAGE_DECORATORS
        builder.Entity<ImageDecorator>().HasOne(i => i.Section)
            .WithOne()
            .HasForeignKey<ImageDecorator>(i => i.SectionId);

        //AOutcome - OUTCOMES_BT
        builder.Entity<AOutcome>().HasOne(o => o.RootSection)
            .WithMany(s=>s.Outcomes)
            .HasForeignKey(o => o.RootSectionId);
        builder.Entity<AOutcome>().HasOne(o => o.Section)
            .WithMany()
            .HasForeignKey(o => o.SectionId);
        
        //AbilityOutcome - ABILITY_OUTCOMES
        builder.Entity<AbilityOutcome>().HasOne(a => a.Ability)
            .WithMany()
            .HasForeignKey(a => a.AbilityType);
        
        //ItemOutcome - ITEM_OUTCOMES
        builder.Entity<ItemOutcome>().HasOne(i => i.Item)
            .WithMany()
            .HasForeignKey(i => i.ItemId);
        
        //CreatureAbility - CREATURE_HAS_ABILITIES_JT
        builder.Entity<CreatureAbility>().HasKey(c => new {c.CreatureId, c.AbilityType});
        builder.Entity<CreatureAbility>().HasOne(c => c.Creature)
            .WithMany()
            .HasForeignKey(c => c.CreatureId);
        builder.Entity<CreatureAbility>().HasOne(c => c.Ability)
            .WithMany()
            .HasForeignKey(c => c.AbilityType);
        
        //AbilityEffect - ABILITY_HAS_EFFECTS_JT
        builder.Entity<AbilityEffect>().HasKey(ae => new {ae.AbilityType, ae.EffectId});
        builder.Entity<AbilityEffect>().HasOne(a => a.Ability)
            .WithMany()
            .HasForeignKey(a => a.AbilityType);
        builder.Entity<AbilityEffect>().HasOne(a => a.Effect)
            .WithMany()
            .HasForeignKey(a => a.EffectId);
        
        //ItemEffect - ITEM_HAS_EFFECTS_JT
        builder.Entity<ItemEffect>().HasKey(ae => new {ae.ItemId, ae.EffectId});
        builder.Entity<ItemEffect>().HasOne(a => a.Item)
            .WithMany()
            .HasForeignKey(a => a.ItemId);
        builder.Entity<ItemEffect>().HasOne(a => a.Effect)
            .WithMany()
            .HasForeignKey(a => a.EffectId);
        
        //AEvent - EVENTS_BT
        builder.Entity<AEvent>().HasOne(e => e.Section)
            .WithMany()
            .HasForeignKey(e => e.SectionId);
        
        //AItemEvent - ITEM_EVENTS_BT
        builder.Entity<AItemEvent>().HasOne(e => e.Item)
            .WithMany()
            .HasForeignKey(e => e.ItemId);
        
        //CombatEvent - COMBAT_EVENTS
        builder.Entity<CombatEvent>().HasOne(e => e.Creature)
            .WithMany()
            .HasForeignKey(e => e.CreatureId);
        
        //Users - USERS
        builder.Entity<User>()
            .HasIndex(u => u.UserName)
            .IsUnique();
        
        builder.Entity<UserRole>()
            .HasIndex(r => r.Identifier)
            .IsUnique();
        
        builder.Entity<UserRoleClaim>()
            .HasKey(rc => new { rc.UserId, rc.RoleId });

        builder.Entity<UserRoleClaim>()
            .HasOne(rc => rc.UserRole)
            .WithMany(r => r.RoleClaims)
            .HasForeignKey(rc => rc.RoleId);
        builder.Entity<UserRoleClaim>()
            .HasOne(rc => rc.User)
            .WithMany(u => u.RoleClaims)
            .HasForeignKey(rc => rc.UserId);

        builder.Entity<UserRole>()
            .HasData(new UserRole[] {
                new UserRole() { Id = 1, Identifier = "User", Description = "Simple User" },
                new UserRole() { Id = 2, Identifier = "Admin", Description = "Administrator" }
            });
        
        // Session - SESSIONS
        builder.Entity<Session>()
            .HasOne(s => s.User)
            .WithMany()
            .HasForeignKey(s => s.UserId);
        
        // PlayedBook - SESSION_HAS_BOOKS_JT
        builder.Entity<PlayedBook>()
            .HasKey(b => new {b.SessionId, b.BookId});

        builder.Entity<PlayedBook>()
            .HasOne(b => b.Session)
            .WithMany(s=>s.BooksPlaying)
            .HasForeignKey(b => b.SessionId);
        builder.Entity<PlayedBook>()
            .HasOne(b => b.Book)
            .WithMany()
            .HasForeignKey(b => b.BookId);

        // Inventory - INVENTORIES
        builder.Entity<Inventory>()
            .Property(i => i.InventoryState)
            .HasConversion<string>();
        
        // Hero - HEROES
        builder.Entity<Hero>()
            .HasOne(h => h.Session)
            .WithOne(s=>s.Hero)
            .HasForeignKey<Hero>(h => h.SessionId);
        builder.Entity<Hero>()
            .HasOne(h => h.HeroLevel)
            .WithMany()
            .HasForeignKey(h => h.HeroLevelValue);
        builder.Entity<Hero>()
            .HasOne(h => h.Inventory)
            .WithMany()
            .HasForeignKey(h => h.InventoryId);
        builder.Entity<Hero>()
            .HasOne(h => h.HeroOwnership)
            .WithMany()
            .HasForeignKey(h => h.HeroOwnershipId);
        
        // InventoryItem - INVENTORY_HAS_ITEMS_JT
        builder.Entity<InventoryItem>()
            .HasKey(i => new {i.InventoryId, i.ItemId});
        builder.Entity<InventoryItem>()
            .HasOne(i => i.Inventory)
            .WithMany(i=>i.Items)
            .HasForeignKey(i => i.InventoryId);
        builder.Entity<InventoryItem>()
            .HasOne(i => i.Item)
            .WithMany()
            .HasForeignKey(i => i.ItemId);
        
        // SectionHistory - SB_HAS_SECTIONS_JT
        builder.Entity<SectionHistory>()
            .HasKey(h => new {h.SessionId, h.BookId, h.SectionId, h.Timestamp});
        builder.Entity<SectionHistory>()
            .HasOne(h => h.PlayedBook)
            .WithMany(h=>h.Sections)
            .HasForeignKey(h => new {h.SessionId, h.BookId});
        builder.Entity<SectionHistory>()
            .HasOne(h => h.Section)
            .WithMany()
            .HasForeignKey(h => h.SectionId);
        
        //HeroAbility - HERO_HAS_ABILITIES
        builder.Entity<HeroAbility>()
            .HasKey(a => new {a.HeroId, a.AbilityType});
        
        builder.Entity<HeroAbility>()
            .HasOne(a => a.Hero)
            .WithMany(h=>h.Abilities)
            .HasForeignKey(a => a.HeroId);
        builder.Entity<HeroAbility>()
            .HasOne(a => a.Ability)
            .WithMany()
            .HasForeignKey(a => a.AbilityType);
    }
}