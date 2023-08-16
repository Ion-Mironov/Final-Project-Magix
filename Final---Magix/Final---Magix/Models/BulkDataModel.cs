using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Final___Magix.Models
{
    public class BulkDataModel
    {

        public class Rootobject
        {
            public BulkDataModel[]? Property1 { get; set; }
        }

        public class BulkDataRoot
        {
            [JsonPropertyName("object")]
            public string? Object { get; set; }
            [JsonPropertyName("id")]
            [Key]
            public string? Id { get; set; }
            [JsonPropertyName("oracle_id")]
            public string? OracleId { get; set; }
            [JsonPropertyName("multiverse_ids")]
            public int[]? MultiverseIds { get; set; }
            [JsonPropertyName("mtgo_id")]
            public int? MtgoId { get; set; }
            [JsonPropertyName("mtgo_foil_id")]
            public int? MtgoFoilId { get; set; }
            [JsonPropertyName("tcgplayer_id")]
            public int? TcgplayerId { get; set; }
            [JsonPropertyName("cardmarket_id")]
            public int? CardmarketId { get; set; }
            [JsonPropertyName("name")]
            public string? Name { get; set; }
            [JsonPropertyName("lang")]
            public string? Lang { get; set; }
            [JsonPropertyName("released_at")]
            public string? ReleasedAt { get; set; }
            [JsonPropertyName("uri")]
            public string? Uri { get; set; }
            [JsonPropertyName("scryfall_uri")]
            public string? ScryfallUri { get; set; }
            [JsonPropertyName("layout")]
            public string? Layout { get; set; }
            [JsonPropertyName("highres_image")]
            public bool HighresImage { get; set; }
            [JsonPropertyName("image_status")]
            public string? ImageStatus { get; set; }
            [JsonPropertyName("image_uris")]
            public Image_Uris? ImageUris { get; set; }
            [JsonPropertyName("mana_cost")]
            public string? ManaCost { get; set; }
            [JsonPropertyName("cmc")]
            public float Cmc { get; set; }
            [JsonPropertyName("type_line")]
            public string? TypeLine { get; set; }
            [JsonPropertyName("oracle_text")]
            public string? OracleText { get; set; }
            [JsonPropertyName("colors")]
            public object[]? Colors { get; set; }
            [JsonPropertyName("color_identity")]
            public object[]? ColorIdentity { get; set; }
            [JsonPropertyName("keywords")]
            public object[]? Keywords { get; set; }
            [JsonPropertyName("legalities")]
            public Legalities? Legalities { get; set; }
            [JsonPropertyName("games")]
            public string[]? Games { get; set; }
            [JsonPropertyName("reserved")]
            public bool Reserved { get; set; }
            [JsonPropertyName("foil")]
            public bool Foil { get; set; }
            [JsonPropertyName("nonfoil")]
            public bool Nonfoil { get; set; }
            [JsonPropertyName("finishes")]
            public string[]? Finishes { get; set; }
            [JsonPropertyName("oversized")]
            public bool Oversized { get; set; }
            [JsonPropertyName("promo")]
            public bool Promo { get; set; }
            [JsonPropertyName("reprint")]
            public bool Reprint { get; set; }
            [JsonPropertyName("variation")]
            public bool Variation { get; set; }
            [JsonPropertyName("set_id")]
            public string? SetId { get; set; }
            [JsonPropertyName("set")]
            public string? Set { get; set; }
            [JsonPropertyName("set_name")]
            public string? SetName { get; set; }
            [JsonPropertyName("set_type")]
            public string? SetType { get; set; }
            [JsonPropertyName("set_uri")]
            public string? setUri { get; set; }
            [JsonPropertyName("set_search_uri")]
            public string? SetSearchUri { get; set; }
            [JsonPropertyName("scryfall_set_uri")]
            public string? ScryfallSetUri { get; set; }
            [JsonPropertyName("rulings_uri")]
            public string? RulingsUri { get; set; }
            [JsonPropertyName("prints_search_uri")]
            public string? PrintsSearchUri { get; set; }
            [JsonPropertyName("collector_number")]
            public string? CollectorNumber { get; set; }
            [JsonPropertyName("digital")]
            public bool Digital { get; set; }
            [JsonPropertyName("rarity")]
            public string? Rarity { get; set; }
            [JsonPropertyName("flavor_text")]
            public string? FlavorText { get; set; }
            [JsonPropertyName("card_back_id")]
            public string? CardBackId { get; set; }
            [JsonPropertyName("artist")]
            public string? Artist { get; set; }
            [JsonPropertyName("artist_ids")]
            public string[]? ArtistIds { get; set; }
            [JsonPropertyName("illustration_id")]
            public string? IllustrationId { get; set; }
            [JsonPropertyName("border_color")]
            public string? BorderColor { get; set; }
            [JsonPropertyName("frame")]
            public string? Frame { get; set; }
            [JsonPropertyName("full_art")]
            public bool FullArt { get; set; }
            [JsonPropertyName("textless")]
            public bool Textless { get; set; }
            [JsonPropertyName("booster")]
            public bool Booster { get; set; }
            [JsonPropertyName("story_spotlight")]
            public bool StorySpotlight { get; set; }
            [JsonPropertyName("edhrec_rank")]
            public int EdhrecRank { get; set; }
            [JsonPropertyName("prices")]
            public Prices? Prices { get; set; }
            [JsonPropertyName("related_uris")]
            public Related_Uris? RelatedUris { get; set; }
            [JsonPropertyName("purchase_uris")]
            public Purchase_Uris? PurchaseUris { get; set; }
        }

        public class Image_Uris
        {
            [JsonPropertyName("small")]
            public string? Small { get; set; }
            [JsonPropertyName("normal")]
            public string? Normal { get; set; }
            [JsonPropertyName("large")]
            public string? Large { get; set; }
            [JsonPropertyName("png")]
            public string? Png { get; set; }
            [JsonPropertyName("art_crop")]
            public string? ArtCrop { get; set; }
            [JsonPropertyName("border_crop")]
            public string? BorderCrop { get; set; }

        }

        public class Legalities
        {
            [JsonPropertyName("standard")]
            public string? Standard { get; set; }
            [JsonPropertyName("future")]
            public string? Future { get; set; }
            [JsonPropertyName("historic")]
            public string? Historic { get; set; }
            [JsonPropertyName("gladiator")]
            public string? Gladiator { get; set; }
            [JsonPropertyName("pioneer")]
            public string? Pioneer { get; set; }
            [JsonPropertyName("explorer")]
            public string? Explorer { get; set; }
            [JsonPropertyName("modern")]
            public string? Modern { get; set; }
            [JsonPropertyName("legacy")]
            public string? Legacy { get; set; }
            [JsonPropertyName("pauper")]
            public string? Pauper { get; set; }
            [JsonPropertyName("vintage")]
            public string? Vintage { get; set; }
            [JsonPropertyName("penny")]
            public string? Penny { get; set; }
            [JsonPropertyName("commander")]
            public string? Commander { get; set; }
            [JsonPropertyName("oathbreaker")]
            public string? Oathbreaker { get; set; }
            [JsonPropertyName("brawl")]
            public string? Brawl { get; set; }
            [JsonPropertyName("historicbrawl")]
            public string? HistoricBrawl { get; set; }
            [JsonPropertyName("alchemy")]
            public string? Alchemy { get; set; }
            [JsonPropertyName("paupercommander")]
            public string? PauperCommander { get; set; }
            [JsonPropertyName("duel")]
            public string? Duel { get; set; }
            [JsonPropertyName("oldschool")]
            public string? Oldschool { get; set; }
            [JsonPropertyName("premodern")]
            public string? Premodern { get; set; }
            [JsonPropertyName("predh")]
            public string? Predh { get; set; }
        }

        public class Prices
        {
            [JsonPropertyName("usd")]
            public decimal Usd { get; set; }
            [JsonPropertyName("usd_foil")]
            public decimal UsdFoil { get; set; }
            [JsonPropertyName("usd_etched")]
            public decimal UsdEtched { get; set; }
            [JsonPropertyName("eur")]
            public decimal Eur { get; set; }
            [JsonPropertyName("eur_foil")]
            public decimal EurFoil { get; set; }
            [JsonPropertyName("tix")]
            public decimal Tix { get; set; }
        }

        public class Related_Uris
        {
            [JsonPropertyName("gatherer")]
            public string? Gatherer { get; set; }
            [JsonPropertyName("tcgplayer_infinite_articles")]
            public string? TcgplayerInfiniteArticles { get; set; }
            [JsonPropertyName("tcgplayer_infinite_decks")]
            public string? TcgplayerInfiniteDecks { get; set; }
            [JsonPropertyName("edhrec")]
            public string? Edhrec { get; set; }

        }

        public class Purchase_Uris
        {
            [JsonPropertyName("tcgplayer")]
            public string? Tcgplayer { get; set; }
            [JsonPropertyName("cardmarket")]
            public string? Cardmarket { get; set; }
            [JsonPropertyName("cardhoarder")]
            public string? Cardhoarder { get; set; }
        }

    }
}
