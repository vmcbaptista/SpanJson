using System.Collections.Generic;
using System.Runtime.InteropServices;
using SpanJson.Benchmarks.Models;
using SpanJson.Codegen;
using SpanJson.Formatters;
using SpanJson.Resolvers;

namespace SpanJson.Benchmarks.Generated
{
    public sealed class PostUtf16Formatter : BaseGeneratedFormatter<Post, char, ExcludeNullsOriginalCaseResolver<char>>,
        IJsonFormatter<Post, char, ExcludeNullsOriginalCaseResolver<char>>
    {
        private const string _post_idName = "\"post_id\":";
        private const string _post_typeName = "\"post_type\":";
        private const string _bodyName = "\"body\":";
        private const string _ownerName = "\"owner\":";
        private const string _creation_dateName = "\"creation_date\":";
        private const string _last_activity_dateName = "\"last_activity_date\":";
        private const string _last_edit_dateName = "\"last_edit_date\":";
        private const string _scoreName = "\"score\":";
        private const string _up_vote_countName = "\"up_vote_count\":";
        private const string _down_vote_countName = "\"down_vote_count\":";
        private const string _commentsName = "\"comments\":";
        private const string _linkName = "\"link\":";
        private const string _upvotedName = "\"upvoted\":";
        private const string _downvotedName = "\"downvoted\":";
        private const string _last_editorName = "\"last_editor\":";
        private const string _comment_countName = "\"comment_count\":";
        private const string _body_markdownName = "\"body_markdown\":";
        private const string _share_linkName = "\"share_link\":";
        public static readonly PostUtf16Formatter Default = new PostUtf16Formatter();

        public Post Deserialize(ref JsonReader<char> reader)
        {
            if (reader.ReadUtf16IsNull())
            {
                return null;
            }

            var result = new Post();
            var count = 0;
            reader.ReadUtf16BeginObjectOrThrow();
            while (!reader.TryReadUtf16IsEndObjectOrValueSeparator(ref count))
            {
                var name = reader.ReadUtf16NameSpan();
                var length = name.Length;
                ref var b = ref MemoryMarshal.GetReference(MemoryMarshal.AsBytes(name));
                if (length >= 4 && ReadUInt64(ref b, 0) == 34058901685993570UL)
                {
                    if (length == 13 && ReadUInt64(ref b, 8) == 32088563963986015UL && ReadUInt64(ref b, 16) == 33495998976491627UL &&
                        ReadUInt16(ref b, 24) == 110)
                    {
                        result.body_markdown = StringUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                        continue;
                    }

                    if (length == 4)
                    {
                        result.body = StringUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                        continue;
                    }

                    reader.SkipNextUtf16Segment();
                    continue;
                }

                if (length == 13 && ReadUInt64(ref b, 0) == 33214455281090677UL && ReadUInt64(ref b, 8) == 26740556586811503UL &&
                    ReadUInt64(ref b, 16) == 30962749956620387UL && ReadUInt16(ref b, 24) == 116)
                {
                    result.up_vote_count = NullableInt32Utf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                    continue;
                }

                if (length >= 4 && ReadUInt64(ref b, 0) == 32651591226949744UL)
                {
                    if (length == 9 && ReadUInt64(ref b, 8) == 31525717090238559UL && ReadUInt16(ref b, 16) == 101)
                    {
                        result.post_type = NullableFormatter<PostType, char, ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                        continue;
                    }

                    if (length == 7 && ReadUInt32(ref b, 8) == 6881375U && ReadUInt16(ref b, 12) == 100)
                    {
                        result.post_id = NullableInt32Utf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                        continue;
                    }

                    reader.SkipNextUtf16Segment();
                    continue;
                }

                if (length >= 4 && ReadUInt64(ref b, 0) == 32651591226032236UL)
                {
                    if (length == 18 && ReadUInt64(ref b, 8) == 32651522506555487UL && ReadUInt64(ref b, 16) == 32651548277735529UL &&
                        ReadUInt64(ref b, 24) == 27303502243889273UL && ReadUInt32(ref b, 32) == 6619252U)
                    {
                        result.last_activity_date = NullableDateTimeUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                        continue;
                    }

                    if (length >= 8 && ReadUInt64(ref b, 8) == 29555302057967711UL)
                    {
                        if (length == 14 && ReadUInt64(ref b, 16) == 27303502243889268UL && ReadUInt32(ref b, 24) == 6619252U)
                        {
                            result.last_edit_date = NullableDateTimeUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                            continue;
                        }

                        if (length == 11 && ReadUInt32(ref b, 16) == 7274612U && ReadUInt16(ref b, 20) == 114)
                        {
                            result.last_editor = ShallowUserUtf16Formatter.Default.Deserialize(ref reader);
                            continue;
                        }

                        reader.SkipNextUtf16Segment();
                        continue;
                    }

                    reader.SkipNextUtf16Segment();
                    continue;
                }

                if (length == 5 && ReadUInt64(ref b, 0) == 32088624092872819UL && ReadUInt16(ref b, 8) == 101)
                {
                    result.score = NullableInt32Utf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                    continue;
                }

                if (length == 10 && ReadUInt64(ref b, 0) == 32088563963658355UL && ReadUInt64(ref b, 8) == 29555336417312869UL &&
                    ReadUInt32(ref b, 16) == 7012462U)
                {
                    result.share_link = StringUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                    continue;
                }

                if (length == 7 && ReadUInt64(ref b, 0) == 31244229228363893UL && ReadUInt32(ref b, 8) == 6619252U && ReadUInt16(ref b, 12) == 100)
                {
                    result.upvoted = NullableBooleanUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                    continue;
                }

                if (length >= 4 && ReadUInt64(ref b, 0) == 30962758546554980UL)
                {
                    if (length == 15 && ReadUInt64(ref b, 8) == 32651574047539295UL && ReadUInt64(ref b, 16) == 31244147622871141UL &&
                        ReadUInt32(ref b, 24) == 7209077U && ReadUInt16(ref b, 28) == 116)
                    {
                        result.down_vote_count = NullableInt32Utf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                        continue;
                    }

                    if (length == 9 && ReadUInt64(ref b, 8) == 28429470871257206UL && ReadUInt16(ref b, 16) == 100)
                    {
                        result.downvoted = NullableBooleanUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                        continue;
                    }

                    reader.SkipNextUtf16Segment();
                    continue;
                }

                if (length >= 4 && ReadUInt64(ref b, 0) == 30681240620171363UL)
                {
                    if (length == 8 && ReadUInt64(ref b, 8) == 32370120545140837UL)
                    {
                        result.comments = ListFormatter<List<Comment>, Comment, char, ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                        continue;
                    }

                    if (length == 13 && ReadUInt64(ref b, 8) == 26740621010927717UL && ReadUInt64(ref b, 16) == 30962749956620387UL &&
                        ReadUInt16(ref b, 24) == 116)
                    {
                        result.comment_count = NullableInt32Utf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                        continue;
                    }

                    reader.SkipNextUtf16Segment();
                    continue;
                }

                if (length == 4 && ReadUInt64(ref b, 0) == 30118294961324140UL)
                {
                    result.link = StringUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                    continue;
                }

                if (length == 5 && ReadUInt64(ref b, 0) == 28429445101977711UL && ReadUInt16(ref b, 8) == 114)
                {
                    result.owner = ShallowUserUtf16Formatter.Default.Deserialize(ref reader);
                    continue;
                }

                if (length == 13 && ReadUInt64(ref b, 0) == 27303506540101731UL && ReadUInt64(ref b, 8) == 30962724186423412UL &&
                    ReadUInt64(ref b, 16) == 32651513916817503UL && ReadUInt16(ref b, 24) == 101)
                {
                    result.creation_date = NullableDateTimeUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Deserialize(ref reader);
                    continue;
                }

                reader.SkipNextUtf16Segment();
            }

            return result;
        }

        public void Serialize(ref JsonWriter<char> writer, Post value, int nestingLimit)
        {
            if (value == null)
            {
                writer.WriteUtf16Null();
                return;
            }

            writer.WriteUtf16BeginObject();
            var writeSeparator = false;
            if (value.post_id != null)
            {
                writer.WriteUtf16Verbatim(_post_idName);
                NullableInt32Utf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.post_id, nestingLimit);
                writeSeparator = true;
            }

            if (value.post_type != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_post_typeName);
                NullableFormatter<PostType, char, ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.post_type, nestingLimit);
                writeSeparator = true;
            }

            if (value.body != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_bodyName);
                StringUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.body, nestingLimit);
                writeSeparator = true;
            }

            if (value.owner != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_ownerName);
                ShallowUserUtf16Formatter.Default.Serialize(ref writer, value.owner, nestingLimit);
                writeSeparator = true;
            }

            if (value.creation_date != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_creation_dateName);
                NullableDateTimeUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.creation_date, nestingLimit);
                writeSeparator = true;
            }

            if (value.last_activity_date != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_last_activity_dateName);
                NullableDateTimeUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.last_activity_date, nestingLimit);
                writeSeparator = true;
            }

            if (value.last_edit_date != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_last_edit_dateName);
                NullableDateTimeUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.last_edit_date, nestingLimit);
                writeSeparator = true;
            }

            if (value.score != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_scoreName);
                NullableInt32Utf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.score, nestingLimit);
                writeSeparator = true;
            }

            if (value.up_vote_count != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_up_vote_countName);
                NullableInt32Utf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.up_vote_count, nestingLimit);
                writeSeparator = true;
            }

            if (value.down_vote_count != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_down_vote_countName);
                NullableInt32Utf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.down_vote_count, nestingLimit);
                writeSeparator = true;
            }

            if (value.comments != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_commentsName);
                ListFormatter<List<Comment>, Comment, char, ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.comments, nestingLimit);
                writeSeparator = true;
            }

            if (value.link != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_linkName);
                StringUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.link, nestingLimit);
                writeSeparator = true;
            }

            if (value.upvoted != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_upvotedName);
                NullableBooleanUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.upvoted, nestingLimit);
                writeSeparator = true;
            }

            if (value.downvoted != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_downvotedName);
                NullableBooleanUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.downvoted, nestingLimit);
                writeSeparator = true;
            }

            if (value.last_editor != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_last_editorName);
                ShallowUserUtf16Formatter.Default.Serialize(ref writer, value.last_editor, nestingLimit);
                writeSeparator = true;
            }

            if (value.comment_count != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_comment_countName);
                NullableInt32Utf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.comment_count, nestingLimit);
                writeSeparator = true;
            }

            if (value.body_markdown != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_body_markdownName);
                StringUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.body_markdown, nestingLimit);
                writeSeparator = true;
            }

            if (value.share_link != null)
            {
                if (writeSeparator)
                {
                    writer.WriteUtf16ValueSeparator();
                }

                writer.WriteUtf16Verbatim(_share_linkName);
                StringUtf16Formatter<ExcludeNullsOriginalCaseResolver<char>>.Default.Serialize(ref writer, value.share_link, nestingLimit);
                writeSeparator = true;
            }

            writer.WriteUtf16EndObject();
        }
    }
}