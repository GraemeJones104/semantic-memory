﻿// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Microsoft.SemanticMemory.Client.Models;

public class DataPipelineStatus
{
    [JsonPropertyOrder(0)]
    [JsonPropertyName("completed")]
    public bool Completed { get; set; } = false;

    [JsonPropertyOrder(1)]
    [JsonPropertyName("failed")]
    public bool Failed { get; set; } = false;

    /// <summary>
    /// Unique Id
    /// </summary>
    [JsonPropertyOrder(10)]
    [JsonPropertyName("document_id")]
    public string DocumentId { get; set; } = string.Empty;

    [JsonPropertyOrder(11)]
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    [JsonPropertyOrder(12)]
    [JsonPropertyName("tags")]
    public TagCollection Tags { get; set; } = new();

    [JsonPropertyOrder(13)]
    [JsonPropertyName("creation")]
    public DateTimeOffset Creation { get; set; } = DateTimeOffset.MinValue;

    [JsonPropertyOrder(14)]
    [JsonPropertyName("last_update")]
    public DateTimeOffset LastUpdate { get; set; }

    /// <summary>
    /// Full list of the steps in this pipeline.
    /// </summary>
    [JsonPropertyOrder(15)]
    [JsonPropertyName("steps")]
    public List<string> Steps { get; set; } = new();

    /// <summary>
    /// List of the steps remaining.
    /// </summary>
    [JsonPropertyOrder(16)]
    [JsonPropertyName("remaining_steps")]
    public List<string> RemainingSteps { get; set; } = new();

    /// <summary>
    /// List of steps already completed.
    /// </summary>
    [JsonPropertyOrder(17)]
    [JsonPropertyName("completed_steps")]
    public List<string> CompletedSteps { get; set; } = new();
}
