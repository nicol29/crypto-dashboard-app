import type { PageLoad } from './$types';

export const load: PageLoad = async ({ fetch, params }) => {
	const res = await fetch(`api/coins`);
	const coins = await res.json();

	return { coins };
};