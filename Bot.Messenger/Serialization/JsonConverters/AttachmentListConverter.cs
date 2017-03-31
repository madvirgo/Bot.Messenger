using Bot.Messenger.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Serialization.JsonConverters
{
    public class AttachmentListConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(List<Attachment>));
        }

        public override object ReadJson(
            JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            JArray array = JArray.Load(reader);

            List<Attachment> attachments = new List<Attachment>();
            
            foreach (JObject obj in array)
            {
                attachments.Add(ParseAttachment(obj, serializer));
            }

            return attachments;
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        private Attachment ParseAttachment(JObject attachmentObj, JsonSerializer serializer)
        {
            AttachmentType attachmentType =
                (AttachmentType)Enum.Parse(typeof(AttachmentType), (string)(attachmentObj["type"]));

            switch (attachmentType)
            {
                case AttachmentType.image:
                case AttachmentType.file:
                case AttachmentType.audio:
                case AttachmentType.video:
                    {
                        return attachmentObj.ToObject<Attachment<UrlPayload>>(serializer);
                    }
                case AttachmentType.fallback:
                    {
                        return attachmentObj.ToObject<WebhookAttachment<Payload>>(serializer);
                    }
                case AttachmentType.template:
                    {
                        return ParseTemplateAttachment(attachmentObj, serializer, attachmentType);
                    }
                case AttachmentType.location:
                    {
                        return attachmentObj.ToObject<WebhookAttachment<LocationPayload>>(serializer);
                    }
                default:
                    return new Attachment { Type = attachmentType };
            }
        }

        private Attachment ParseTemplateAttachment(
            JObject attachmentObj, JsonSerializer serializer, AttachmentType attachmentType)
        {
            TemplateType templateType =
                (TemplateType)Enum.Parse(typeof(TemplateType), (string)(attachmentObj["payload"]["template_type"]));

            switch (templateType)
            {
                case TemplateType.generic:
                    return attachmentObj.ToObject<Attachment<GenericTemplate>>(serializer);
                case TemplateType.list:
                    return attachmentObj.ToObject<Attachment<ListTemplate>>(serializer);
                case TemplateType.button:
                    return attachmentObj.ToObject<Attachment<ButtonTemplate>>(serializer);
                case TemplateType.receipt:
                    return attachmentObj.ToObject<Attachment<ReceiptTemplate>>(serializer);
                case TemplateType.airline_boardingpass:
                    return attachmentObj.ToObject<Attachment<AirlineBordingPassTemplate>>(serializer);
                case TemplateType.airline_checkin:
                    return attachmentObj.ToObject<Attachment<AirlineCheckinReminderTemplate>>(serializer);
                case TemplateType.airline_itinerary:
                    return attachmentObj.ToObject<Attachment<AirlineItinaryTemplate>>(serializer);
                case TemplateType.airline_update:
                    return attachmentObj.ToObject<Attachment<AirlineFlightUpdateTemplate>>(serializer);
                default:
                    return new Attachment { Type = attachmentType };
            }
        }
    }
}
