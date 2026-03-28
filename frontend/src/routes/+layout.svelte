<script lang="ts">
	import './layout.css';
	import favicon from '$lib/assets/favicon.svg';
	import Header from '$lib/components/header/header.svelte';

	let { children } = $props();
</script>

<Header />

<svelte:head><link rel="icon" href={favicon} /></svelte:head>
{@render children()}
