// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> A text block in a new message, containing plain text content. </summary>
    public partial class MessageInputTextBlock : MessageInputContentBlock
    {
        /// <summary> Initializes a new instance of <see cref="MessageInputTextBlock"/>. </summary>
        /// <param name="text"> The plain text content for this block. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        public MessageInputTextBlock(string text)
        {
            Argument.AssertNotNull(text, nameof(text));

            Type = MessageBlockType.Text;
            Text = text;
        }

        /// <summary> Initializes a new instance of <see cref="MessageInputTextBlock"/>. </summary>
        /// <param name="type"> Specifies which kind of content block this is (text, image_file, image_url, etc.). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="text"> The plain text content for this block. </param>
        internal MessageInputTextBlock(MessageBlockType type, IDictionary<string, BinaryData> serializedAdditionalRawData, string text) : base(type, serializedAdditionalRawData)
        {
            Text = text;
        }

        /// <summary> Initializes a new instance of <see cref="MessageInputTextBlock"/> for deserialization. </summary>
        internal MessageInputTextBlock()
        {
        }

        /// <summary> The plain text content for this block. </summary>
        public string Text { get; }
    }
}
