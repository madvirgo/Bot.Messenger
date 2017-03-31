using Bot.Messenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Tools
{
    public class AttachmentHandler
    {
        public static Attachment<T> GenerateTemplateAttachment<T>(T template) where T : TemplatePayload
        {
            return new Attachment<T>
            {
                Type = AttachmentType.template,
                Payload = template
            };
        }

        public static Attachment<UrlPayload> GenerateAudioAttachment(string audioResourceUrl)
        {
            return GenerateUrlPayloadAttachment(AttachmentType.audio, audioResourceUrl);
        }

        public static Attachment<UrlPayload> GenerateFileAttachment(string fileResourceUrl)
        {
            return GenerateUrlPayloadAttachment(AttachmentType.file, fileResourceUrl);
        }

        public static Attachment<UrlPayload> GenerateImageAttachment(string imageResourceUrl)
        {
            return GenerateUrlPayloadAttachment(AttachmentType.image, imageResourceUrl);
        }

        public static Attachment<UrlPayload> GenerateVideoAttachment(string videoResourceUrl)
        {
            return GenerateUrlPayloadAttachment(AttachmentType.video, videoResourceUrl);
        }

        public static Attachment<UrlPayload> GenerateUrlPayloadAttachment(AttachmentType type, string resourceUrl)
        {
            return new Attachment<UrlPayload>
            {
                Type = type,
                Payload = new UrlPayload { URL = resourceUrl }
            };
        }
    }
}
