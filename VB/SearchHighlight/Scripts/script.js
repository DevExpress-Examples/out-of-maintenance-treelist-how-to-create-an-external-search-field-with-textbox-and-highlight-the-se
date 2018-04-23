var currentSearchText = '';

function onTreeListBeginCallback(s, e) {
    e.customArgs['SearchText'] = currentSearchText;
}

function onSearchButtonClick(s, e) {
    currentSearchText = SearchText.GetValue();
    TreeList.PerformCallback({ isNewSearch: true });
}